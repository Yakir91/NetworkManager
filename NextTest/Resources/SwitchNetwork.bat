@ECHO OFF

IF NOT [%1]==[] (
  IF [%1]==[US] (
  
    netsh interface set interface "EthernetIL" DISABLED
    netsh interface set interface "EthernetUS" ENABLED
	netsh interface show interface name="EthernetUS" | find "Connect state" |find "Connected" > nul || exit 1
	echo "US Active"
	
  ) ELSE IF [%1]==[IL] (
 
    netsh interface set interface "EthernetUS" DISABLED
    netsh interface set interface "EthernetIL" ENABLED
	netsh interface show interface name="EthernetIL" | find "Connect state" |find "Connected" > nul || exit 1
    echo "IL Active"

  ) ELSE (
    netsh interface set interface "EthernetIL" DISABLED
    netsh interface set interface "EthernetUS" DISABLED
    echo "Network is disabled"
  )
)