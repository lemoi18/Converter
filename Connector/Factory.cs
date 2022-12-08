///////////////////////////////////////////////////////////
//  Factory.cs
//  Implementation of the Class Factory
//  Generated by Enterprise Architect
//  Created on:      26-nov-2022 12:23:52
//  Original author: Skole
///////////////////////////////////////////////////////////

namespace Connector
{
	public static class ConnectorFactory
	{


		public static IC CreateConnectorFactory(string name)
		{
			IC connector = null;

			if (name.ToUpper() == "CONNECTOR")
				connector = new Conn();
			
				

			return connector;
		}




	}



}//end namespace Connector