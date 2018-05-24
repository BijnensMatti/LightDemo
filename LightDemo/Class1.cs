using System;
using System.Collections.Generic;
using System.Text;

namespace LightDemo
{
    class Light
    {
        public int LightId { get; set; }
        public Light(int id)
        {
            this.LightId = id;
        }
    }

    class LightAndState
    {
        public Light Light { get; set; }
        public LightState State { get; set; }

        public LightAndState(Light light, LightState state)
        {
            this.Light = light;
            this.State = state;
        }
    }

    enum LightState
    {
        GREEN, AMBER, RED
    }
}
