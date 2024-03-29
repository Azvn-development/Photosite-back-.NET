﻿using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Abouts
{
    public class GetAboutsQuery: IBaseQuery<GetAboutsResponse> { }

    public class GetAboutsResponse
    {
        public List<AboutModel> Abouts { get; set; }
    }
}
