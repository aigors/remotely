﻿import { RCBrowserSockets } from "./RCBrowserSockets.js";
import { RemoteControlMode } from "../Enums/RemoteControlMode.js";

export class Conductor {
    constructor(rcBrowserSockets: RCBrowserSockets, clientID: string, serviceID: string) {
        this.RCBrowserSockets = rcBrowserSockets;
        this.ClientID = clientID;
        this.ServiceID = serviceID;
    }
    RCBrowserSockets: RCBrowserSockets;
    ClientID: string = "";
    ServiceID : string = "";
    Mode: RemoteControlMode;
    RequesterName: string = "";
}