using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstructor.DocPatterns.MainPage
{
    public class MainPageText
    {
        public string actuality, newie, programSpecs, target, 
            metasubjectTasks, personalTasks, subjectTasks, plannedResMetasubjects, 
            plannedResSubjects, plannedResPersonal;
        public string knowledgeLvl, programFocus;
        public string markedMaterials, methodologicalMaterials, methodologicalTech, briefContentMaterials;

        public MainPageText(string a, string n, string ps, string t, string mT, string pT, 
            string sT, string pRM, string pRS, string pRP, string knL, string pF, string mM, string meM, string methT, string briefC)
        {
            this.actuality = a;
            this.newie = n;
            this.programSpecs = ps;
            this.target = t;
            this.metasubjectTasks = mT;
            this.personalTasks = pT;
            this.subjectTasks = sT;
            this.plannedResMetasubjects = pRM;
            this.plannedResSubjects = pRS;
            this.plannedResPersonal = pRP;
            this.knowledgeLvl = knL;
            this.programFocus = pF;
            this. markedMaterials = mM;
            this.methodologicalMaterials = meM;
            this.methodologicalTech = methT;
            this.briefContentMaterials = briefC;
        }
    }
}
