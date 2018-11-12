using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {
    public class Controller
    {
        public enum Brand
        {
            NULL = 0,
            Xbox = 1,
            Switch = 2
        }
        public Brand brand = Brand.NULL;

        public int number = 0;

        public void XboxConnect()
        {
            for(int i = 1; i < 17; i++)
            {
                if(Input.GetAxisRaw("P" + i + " Xbox H") != 0)
                {
                    XboxDone(i);
                }
                if(Input.GetAxisRaw("P" + i + " Xbox V") != 0)
                {
                    XboxDone(i);
                }
                if(Input.GetAxisRaw("P" + i + " Xbox A") != 0)
                {
                    XboxDone(i);
                }
                if(Input.GetAxisRaw("P" + i + " Xbox B") != 0)
                {
                    XboxDone(i);
                }
                if(Input.GetAxisRaw("P" + i + " Xbox X") != 0)
                {
                    XboxDone(i);
                }
                if(Input.GetAxisRaw("P" + i + " Xbox Y") != 0)
                {
                    XboxDone(i);
                }
            }
        }
        public void XboxDone(int i)
        {
            brand = Brand.Xbox;
            number = i;
            Debug.Log("Xbox controller #" + number + " connected!");
        }

        public void SwitchConnect()
        {
            for (int i = 1; i < 17; i++)
            {
                if (Input.GetAxisRaw("P" + i + " Switch H") != 0 ||
                Input.GetAxisRaw("P" + i + " Switch V") != 0 ||
                Input.GetAxisRaw("P" + i + " Switch A") != 0 ||
                Input.GetAxisRaw("P" + i + " Switch B") != 0 ||
                Input.GetAxisRaw("P" + i + " Switch X") != 0 ||
                Input.GetAxisRaw("P" + i + " Switch Y") != 0)
                {
                    brand = Brand.Switch;
                    number = i;
                    Debug.Log("Switch controller #" + number + " connected!");
                    return;
                }
            }
            return;
        }

        public Controller()
        {
            brand = Brand.NULL;
            number = 0;
        }
    }
    public Controller controller1 = new Controller();
    public Controller controller2 = new Controller();
    public Controller controller3 = new Controller();
    public Controller controller4 = new Controller();

    private void Update()
    {
        if(controller1.brand == Controller.Brand.NULL)
        {
            controller1.XboxConnect();
            //controller1.SwitchConnect();
            Debug.Log("connecting Controller #1");
        }
        /*
        if (controller2.brand == Controller.Brand.NULL)
        {
            controller2.XboxConnect();
            //controller2.SwitchConnect();
            Debug.Log("connecting Controller #2");
        }

        if (controller3.brand == Controller.Brand.NULL)
        {
            controller3.XboxConnect();
            //controller3.SwitchConnect();
            Debug.Log("connecting Controller #3");
        }

        if (controller4.brand == Controller.Brand.NULL)
        {
            controller4.XboxConnect();
            //controller4.SwitchConnect();
            Debug.Log("connecting Controller #4");
        }
        */
    }
}
