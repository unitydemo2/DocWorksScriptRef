using System.Collections.Generic;
using DocWorks.Common.DataAccess.Entity;
using DocWorks.Common.DataAccess.Enumerations;

namespace DocWorks.Core.Tests.ConstantEntities
{
    public static class DistributionList
    {
        public static List<Distribution> Value = new List<Distribution>
        {
            new Distribution
            {
                Id= "5b1a8688fac693156446666f",
                Status= EntityStatus.Ok,
                ProjectId= "5b1a812efac6931564466664",
                DistributionName= "DocWorksDistributions-08Jun0254-1551237972123bcd",
                BranchName= "DocworksManual2",
                Description= null,
                IsDefault= false,
                IsActive= false,
                TocPath= "",
                LastAcceptToLiveDate= 0,
                BranchNameCounter= 2,
                DocWorksBranchName= "DW/DocworksManual2/docworksmastertemp-project-08jun-233-1528487591/docworksdistributions-08jun0254-1551237972123bcd/Manual-2"
            },
            new Distribution
            {
                Id= "5b1a8698fac6931564466670",
                Status= EntityStatus.Ok,
                ProjectId= "5b1a812efac6931564466664",
                DistributionName= "DocWorksDistributions-08Jun0254-1551237972123bcdef",
                BranchName= "DocworksManual2",
                Description= null,
                IsDefault= false,
                IsActive= true,
                TocPath= "",
                LastAcceptToLiveDate= 1528695090,
                BranchNameCounter= 0,
                DocWorksBranchName= "DW/DocworksManual2/docworksmastertemp-project-08jun-233-1528487591/docworksdistributions-08jun0254-1551237972123bcdef/Manual-0"
            }
        };
    }
}
