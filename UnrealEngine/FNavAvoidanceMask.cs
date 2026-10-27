using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ED2 RID: 3794
	[UnrealObjectPath("/Script/Engine.NavAvoidanceMask")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNavAvoidanceMask : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CD56 RID: 52566 RVA: 0x0012B1AD File Offset: 0x001293AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavAvoidanceMask._ScriptStructPtr != 0) ? FNavAvoidanceMask._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavAvoidanceMask", ref FNavAvoidanceMask._ScriptStructPtr);
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0600CD57 RID: 52567 RVA: 0x0012B1D1 File Offset: 0x001293D1
		// (set) Token: 0x0600CD58 RID: 52568 RVA: 0x0012B1EA File Offset: 0x001293EA
		public unsafe bool bGroup0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup0) & FNavAvoidanceMask.__PropertyMask_bGroup0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup0) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup0) & ~FNavAvoidanceMask.__PropertyMask_bGroup0) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup0 : 0));
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0600CD59 RID: 52569 RVA: 0x0012B21A File Offset: 0x0012941A
		// (set) Token: 0x0600CD5A RID: 52570 RVA: 0x0012B233 File Offset: 0x00129433
		public unsafe bool bGroup1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup1) & FNavAvoidanceMask.__PropertyMask_bGroup1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup1) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup1) & ~FNavAvoidanceMask.__PropertyMask_bGroup1) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup1 : 0));
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0600CD5B RID: 52571 RVA: 0x0012B263 File Offset: 0x00129463
		// (set) Token: 0x0600CD5C RID: 52572 RVA: 0x0012B27C File Offset: 0x0012947C
		public unsafe bool bGroup2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup2) & FNavAvoidanceMask.__PropertyMask_bGroup2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup2) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup2) & ~FNavAvoidanceMask.__PropertyMask_bGroup2) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup2 : 0));
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0600CD5D RID: 52573 RVA: 0x0012B2AC File Offset: 0x001294AC
		// (set) Token: 0x0600CD5E RID: 52574 RVA: 0x0012B2C5 File Offset: 0x001294C5
		public unsafe bool bGroup3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup3) & FNavAvoidanceMask.__PropertyMask_bGroup3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup3) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup3) & ~FNavAvoidanceMask.__PropertyMask_bGroup3) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup3 : 0));
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0600CD5F RID: 52575 RVA: 0x0012B2F5 File Offset: 0x001294F5
		// (set) Token: 0x0600CD60 RID: 52576 RVA: 0x0012B30E File Offset: 0x0012950E
		public unsafe bool bGroup4
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup4) & FNavAvoidanceMask.__PropertyMask_bGroup4) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup4) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup4) & ~FNavAvoidanceMask.__PropertyMask_bGroup4) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup4 : 0));
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0600CD61 RID: 52577 RVA: 0x0012B33E File Offset: 0x0012953E
		// (set) Token: 0x0600CD62 RID: 52578 RVA: 0x0012B357 File Offset: 0x00129557
		public unsafe bool bGroup5
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup5) & FNavAvoidanceMask.__PropertyMask_bGroup5) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup5) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup5) & ~FNavAvoidanceMask.__PropertyMask_bGroup5) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup5 : 0));
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0600CD63 RID: 52579 RVA: 0x0012B387 File Offset: 0x00129587
		// (set) Token: 0x0600CD64 RID: 52580 RVA: 0x0012B3A0 File Offset: 0x001295A0
		public unsafe bool bGroup6
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup6) & FNavAvoidanceMask.__PropertyMask_bGroup6) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup6) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup6) & ~FNavAvoidanceMask.__PropertyMask_bGroup6) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup6 : 0));
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0600CD65 RID: 52581 RVA: 0x0012B3D0 File Offset: 0x001295D0
		// (set) Token: 0x0600CD66 RID: 52582 RVA: 0x0012B3E9 File Offset: 0x001295E9
		public unsafe bool bGroup7
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup7) & FNavAvoidanceMask.__PropertyMask_bGroup7) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup7) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup7) & ~FNavAvoidanceMask.__PropertyMask_bGroup7) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup7 : 0));
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x0600CD67 RID: 52583 RVA: 0x0012B419 File Offset: 0x00129619
		// (set) Token: 0x0600CD68 RID: 52584 RVA: 0x0012B432 File Offset: 0x00129632
		public unsafe bool bGroup8
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup8) & FNavAvoidanceMask.__PropertyMask_bGroup8) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup8) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup8) & ~FNavAvoidanceMask.__PropertyMask_bGroup8) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup8 : 0));
			}
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0600CD69 RID: 52585 RVA: 0x0012B462 File Offset: 0x00129662
		// (set) Token: 0x0600CD6A RID: 52586 RVA: 0x0012B47B File Offset: 0x0012967B
		public unsafe bool bGroup9
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup9) & FNavAvoidanceMask.__PropertyMask_bGroup9) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup9) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup9) & ~FNavAvoidanceMask.__PropertyMask_bGroup9) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup9 : 0));
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0600CD6B RID: 52587 RVA: 0x0012B4AB File Offset: 0x001296AB
		// (set) Token: 0x0600CD6C RID: 52588 RVA: 0x0012B4C4 File Offset: 0x001296C4
		public unsafe bool bGroup10
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup10) & FNavAvoidanceMask.__PropertyMask_bGroup10) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup10) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup10) & ~FNavAvoidanceMask.__PropertyMask_bGroup10) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup10 : 0));
			}
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x0600CD6D RID: 52589 RVA: 0x0012B4F4 File Offset: 0x001296F4
		// (set) Token: 0x0600CD6E RID: 52590 RVA: 0x0012B50D File Offset: 0x0012970D
		public unsafe bool bGroup11
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup11) & FNavAvoidanceMask.__PropertyMask_bGroup11) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup11) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup11) & ~FNavAvoidanceMask.__PropertyMask_bGroup11) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup11 : 0));
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x0600CD6F RID: 52591 RVA: 0x0012B53D File Offset: 0x0012973D
		// (set) Token: 0x0600CD70 RID: 52592 RVA: 0x0012B556 File Offset: 0x00129756
		public unsafe bool bGroup12
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup12) & FNavAvoidanceMask.__PropertyMask_bGroup12) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup12) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup12) & ~FNavAvoidanceMask.__PropertyMask_bGroup12) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup12 : 0));
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x0600CD71 RID: 52593 RVA: 0x0012B586 File Offset: 0x00129786
		// (set) Token: 0x0600CD72 RID: 52594 RVA: 0x0012B59F File Offset: 0x0012979F
		public unsafe bool bGroup13
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup13) & FNavAvoidanceMask.__PropertyMask_bGroup13) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup13) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup13) & ~FNavAvoidanceMask.__PropertyMask_bGroup13) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup13 : 0));
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x0600CD73 RID: 52595 RVA: 0x0012B5CF File Offset: 0x001297CF
		// (set) Token: 0x0600CD74 RID: 52596 RVA: 0x0012B5E8 File Offset: 0x001297E8
		public unsafe bool bGroup14
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup14) & FNavAvoidanceMask.__PropertyMask_bGroup14) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup14) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup14) & ~FNavAvoidanceMask.__PropertyMask_bGroup14) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup14 : 0));
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0600CD75 RID: 52597 RVA: 0x0012B618 File Offset: 0x00129818
		// (set) Token: 0x0600CD76 RID: 52598 RVA: 0x0012B631 File Offset: 0x00129831
		public unsafe bool bGroup15
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup15) & FNavAvoidanceMask.__PropertyMask_bGroup15) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup15) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup15) & ~FNavAvoidanceMask.__PropertyMask_bGroup15) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup15 : 0));
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0600CD77 RID: 52599 RVA: 0x0012B661 File Offset: 0x00129861
		// (set) Token: 0x0600CD78 RID: 52600 RVA: 0x0012B67A File Offset: 0x0012987A
		public unsafe bool bGroup16
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup16) & FNavAvoidanceMask.__PropertyMask_bGroup16) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup16) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup16) & ~FNavAvoidanceMask.__PropertyMask_bGroup16) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup16 : 0));
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x0600CD79 RID: 52601 RVA: 0x0012B6AA File Offset: 0x001298AA
		// (set) Token: 0x0600CD7A RID: 52602 RVA: 0x0012B6C3 File Offset: 0x001298C3
		public unsafe bool bGroup17
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup17) & FNavAvoidanceMask.__PropertyMask_bGroup17) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup17) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup17) & ~FNavAvoidanceMask.__PropertyMask_bGroup17) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup17 : 0));
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x0600CD7B RID: 52603 RVA: 0x0012B6F3 File Offset: 0x001298F3
		// (set) Token: 0x0600CD7C RID: 52604 RVA: 0x0012B70C File Offset: 0x0012990C
		public unsafe bool bGroup18
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup18) & FNavAvoidanceMask.__PropertyMask_bGroup18) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup18) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup18) & ~FNavAvoidanceMask.__PropertyMask_bGroup18) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup18 : 0));
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x0600CD7D RID: 52605 RVA: 0x0012B73C File Offset: 0x0012993C
		// (set) Token: 0x0600CD7E RID: 52606 RVA: 0x0012B755 File Offset: 0x00129955
		public unsafe bool bGroup19
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup19) & FNavAvoidanceMask.__PropertyMask_bGroup19) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup19) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup19) & ~FNavAvoidanceMask.__PropertyMask_bGroup19) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup19 : 0));
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x0600CD7F RID: 52607 RVA: 0x0012B785 File Offset: 0x00129985
		// (set) Token: 0x0600CD80 RID: 52608 RVA: 0x0012B79E File Offset: 0x0012999E
		public unsafe bool bGroup20
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup20) & FNavAvoidanceMask.__PropertyMask_bGroup20) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup20) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup20) & ~FNavAvoidanceMask.__PropertyMask_bGroup20) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup20 : 0));
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0600CD81 RID: 52609 RVA: 0x0012B7CE File Offset: 0x001299CE
		// (set) Token: 0x0600CD82 RID: 52610 RVA: 0x0012B7E7 File Offset: 0x001299E7
		public unsafe bool bGroup21
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup21) & FNavAvoidanceMask.__PropertyMask_bGroup21) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup21) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup21) & ~FNavAvoidanceMask.__PropertyMask_bGroup21) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup21 : 0));
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0600CD83 RID: 52611 RVA: 0x0012B817 File Offset: 0x00129A17
		// (set) Token: 0x0600CD84 RID: 52612 RVA: 0x0012B830 File Offset: 0x00129A30
		public unsafe bool bGroup22
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup22) & FNavAvoidanceMask.__PropertyMask_bGroup22) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup22) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup22) & ~FNavAvoidanceMask.__PropertyMask_bGroup22) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup22 : 0));
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0600CD85 RID: 52613 RVA: 0x0012B860 File Offset: 0x00129A60
		// (set) Token: 0x0600CD86 RID: 52614 RVA: 0x0012B879 File Offset: 0x00129A79
		public unsafe bool bGroup23
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup23) & FNavAvoidanceMask.__PropertyMask_bGroup23) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup23) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup23) & ~FNavAvoidanceMask.__PropertyMask_bGroup23) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup23 : 0));
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0600CD87 RID: 52615 RVA: 0x0012B8A9 File Offset: 0x00129AA9
		// (set) Token: 0x0600CD88 RID: 52616 RVA: 0x0012B8C2 File Offset: 0x00129AC2
		public unsafe bool bGroup24
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup24) & FNavAvoidanceMask.__PropertyMask_bGroup24) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup24) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup24) & ~FNavAvoidanceMask.__PropertyMask_bGroup24) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup24 : 0));
			}
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0600CD89 RID: 52617 RVA: 0x0012B8F2 File Offset: 0x00129AF2
		// (set) Token: 0x0600CD8A RID: 52618 RVA: 0x0012B90B File Offset: 0x00129B0B
		public unsafe bool bGroup25
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup25) & FNavAvoidanceMask.__PropertyMask_bGroup25) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup25) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup25) & ~FNavAvoidanceMask.__PropertyMask_bGroup25) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup25 : 0));
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0600CD8B RID: 52619 RVA: 0x0012B93B File Offset: 0x00129B3B
		// (set) Token: 0x0600CD8C RID: 52620 RVA: 0x0012B954 File Offset: 0x00129B54
		public unsafe bool bGroup26
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup26) & FNavAvoidanceMask.__PropertyMask_bGroup26) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup26) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup26) & ~FNavAvoidanceMask.__PropertyMask_bGroup26) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup26 : 0));
			}
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0600CD8D RID: 52621 RVA: 0x0012B984 File Offset: 0x00129B84
		// (set) Token: 0x0600CD8E RID: 52622 RVA: 0x0012B99D File Offset: 0x00129B9D
		public unsafe bool bGroup27
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup27) & FNavAvoidanceMask.__PropertyMask_bGroup27) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup27) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup27) & ~FNavAvoidanceMask.__PropertyMask_bGroup27) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup27 : 0));
			}
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0600CD8F RID: 52623 RVA: 0x0012B9CD File Offset: 0x00129BCD
		// (set) Token: 0x0600CD90 RID: 52624 RVA: 0x0012B9E6 File Offset: 0x00129BE6
		public unsafe bool bGroup28
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup28) & FNavAvoidanceMask.__PropertyMask_bGroup28) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup28) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup28) & ~FNavAvoidanceMask.__PropertyMask_bGroup28) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup28 : 0));
			}
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0600CD91 RID: 52625 RVA: 0x0012BA16 File Offset: 0x00129C16
		// (set) Token: 0x0600CD92 RID: 52626 RVA: 0x0012BA2F File Offset: 0x00129C2F
		public unsafe bool bGroup29
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup29) & FNavAvoidanceMask.__PropertyMask_bGroup29) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup29) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup29) & ~FNavAvoidanceMask.__PropertyMask_bGroup29) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup29 : 0));
			}
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0600CD93 RID: 52627 RVA: 0x0012BA5F File Offset: 0x00129C5F
		// (set) Token: 0x0600CD94 RID: 52628 RVA: 0x0012BA78 File Offset: 0x00129C78
		public unsafe bool bGroup30
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup30) & FNavAvoidanceMask.__PropertyMask_bGroup30) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup30) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup30) & ~FNavAvoidanceMask.__PropertyMask_bGroup30) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup30 : 0));
			}
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0600CD95 RID: 52629 RVA: 0x0012BAA8 File Offset: 0x00129CA8
		// (set) Token: 0x0600CD96 RID: 52630 RVA: 0x0012BAC1 File Offset: 0x00129CC1
		public unsafe bool bGroup31
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup31) & FNavAvoidanceMask.__PropertyMask_bGroup31) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup31) = ((*(base.NativePtr + (IntPtr)FNavAvoidanceMask.__PropertyOffset_bGroup31) & ~FNavAvoidanceMask.__PropertyMask_bGroup31) | (value ? FNavAvoidanceMask.__PropertyMask_bGroup31 : 0));
			}
		}

		// Token: 0x0600CD97 RID: 52631 RVA: 0x0012BAF1 File Offset: 0x00129CF1
		public FNavAvoidanceMask()
		{
		}

		// Token: 0x0600CD98 RID: 52632 RVA: 0x0012BAFC File Offset: 0x00129CFC
		public FNavAvoidanceMask(bool bGroup0, bool bGroup1, bool bGroup2, bool bGroup3, bool bGroup4, bool bGroup5, bool bGroup6, bool bGroup7, bool bGroup8, bool bGroup9, bool bGroup10, bool bGroup11, bool bGroup12, bool bGroup13, bool bGroup14, bool bGroup15, bool bGroup16, bool bGroup17, bool bGroup18, bool bGroup19, bool bGroup20, bool bGroup21, bool bGroup22, bool bGroup23, bool bGroup24, bool bGroup25, bool bGroup26, bool bGroup27, bool bGroup28, bool bGroup29, bool bGroup30, bool bGroup31)
		{
			this.bGroup0 = bGroup0;
			this.bGroup1 = bGroup1;
			this.bGroup2 = bGroup2;
			this.bGroup3 = bGroup3;
			this.bGroup4 = bGroup4;
			this.bGroup5 = bGroup5;
			this.bGroup6 = bGroup6;
			this.bGroup7 = bGroup7;
			this.bGroup8 = bGroup8;
			this.bGroup9 = bGroup9;
			this.bGroup10 = bGroup10;
			this.bGroup11 = bGroup11;
			this.bGroup12 = bGroup12;
			this.bGroup13 = bGroup13;
			this.bGroup14 = bGroup14;
			this.bGroup15 = bGroup15;
			this.bGroup16 = bGroup16;
			this.bGroup17 = bGroup17;
			this.bGroup18 = bGroup18;
			this.bGroup19 = bGroup19;
			this.bGroup20 = bGroup20;
			this.bGroup21 = bGroup21;
			this.bGroup22 = bGroup22;
			this.bGroup23 = bGroup23;
			this.bGroup24 = bGroup24;
			this.bGroup25 = bGroup25;
			this.bGroup26 = bGroup26;
			this.bGroup27 = bGroup27;
			this.bGroup28 = bGroup28;
			this.bGroup29 = bGroup29;
			this.bGroup30 = bGroup30;
			this.bGroup31 = bGroup31;
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x0012BC0C File Offset: 0x00129E0C
		protected override IntPtr GetUStructPtr()
		{
			return FNavAvoidanceMask.StaticStruct();
		}

		// Token: 0x0600CD9A RID: 52634 RVA: 0x0012BC18 File Offset: 0x00129E18
		[NullableContext(2)]
		public FNavAvoidanceMask(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CD9B RID: 52635 RVA: 0x0012BC22 File Offset: 0x00129E22
		public FNavAvoidanceMask(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CD9C RID: 52636 RVA: 0x0012BC2D File Offset: 0x00129E2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavAvoidanceMask(Pointer, false, true);
		}

		// Token: 0x0600CD9D RID: 52637 RVA: 0x0012BC37 File Offset: 0x00129E37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavAvoidanceMask(Pointer, MemoryOwner);
		}

		// Token: 0x04006E86 RID: 28294
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavAvoidanceMask";

		// Token: 0x04006E87 RID: 28295
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E88 RID: 28296
		internal static int __PropertyOffset_bGroup0;

		// Token: 0x04006E89 RID: 28297
		internal static byte __PropertyMask_bGroup0;

		// Token: 0x04006E8A RID: 28298
		internal static int __PropertyOffset_bGroup1;

		// Token: 0x04006E8B RID: 28299
		internal static byte __PropertyMask_bGroup1;

		// Token: 0x04006E8C RID: 28300
		internal static int __PropertyOffset_bGroup2;

		// Token: 0x04006E8D RID: 28301
		internal static byte __PropertyMask_bGroup2;

		// Token: 0x04006E8E RID: 28302
		internal static int __PropertyOffset_bGroup3;

		// Token: 0x04006E8F RID: 28303
		internal static byte __PropertyMask_bGroup3;

		// Token: 0x04006E90 RID: 28304
		internal static int __PropertyOffset_bGroup4;

		// Token: 0x04006E91 RID: 28305
		internal static byte __PropertyMask_bGroup4;

		// Token: 0x04006E92 RID: 28306
		internal static int __PropertyOffset_bGroup5;

		// Token: 0x04006E93 RID: 28307
		internal static byte __PropertyMask_bGroup5;

		// Token: 0x04006E94 RID: 28308
		internal static int __PropertyOffset_bGroup6;

		// Token: 0x04006E95 RID: 28309
		internal static byte __PropertyMask_bGroup6;

		// Token: 0x04006E96 RID: 28310
		internal static int __PropertyOffset_bGroup7;

		// Token: 0x04006E97 RID: 28311
		internal static byte __PropertyMask_bGroup7;

		// Token: 0x04006E98 RID: 28312
		internal static int __PropertyOffset_bGroup8;

		// Token: 0x04006E99 RID: 28313
		internal static byte __PropertyMask_bGroup8;

		// Token: 0x04006E9A RID: 28314
		internal static int __PropertyOffset_bGroup9;

		// Token: 0x04006E9B RID: 28315
		internal static byte __PropertyMask_bGroup9;

		// Token: 0x04006E9C RID: 28316
		internal static int __PropertyOffset_bGroup10;

		// Token: 0x04006E9D RID: 28317
		internal static byte __PropertyMask_bGroup10;

		// Token: 0x04006E9E RID: 28318
		internal static int __PropertyOffset_bGroup11;

		// Token: 0x04006E9F RID: 28319
		internal static byte __PropertyMask_bGroup11;

		// Token: 0x04006EA0 RID: 28320
		internal static int __PropertyOffset_bGroup12;

		// Token: 0x04006EA1 RID: 28321
		internal static byte __PropertyMask_bGroup12;

		// Token: 0x04006EA2 RID: 28322
		internal static int __PropertyOffset_bGroup13;

		// Token: 0x04006EA3 RID: 28323
		internal static byte __PropertyMask_bGroup13;

		// Token: 0x04006EA4 RID: 28324
		internal static int __PropertyOffset_bGroup14;

		// Token: 0x04006EA5 RID: 28325
		internal static byte __PropertyMask_bGroup14;

		// Token: 0x04006EA6 RID: 28326
		internal static int __PropertyOffset_bGroup15;

		// Token: 0x04006EA7 RID: 28327
		internal static byte __PropertyMask_bGroup15;

		// Token: 0x04006EA8 RID: 28328
		internal static int __PropertyOffset_bGroup16;

		// Token: 0x04006EA9 RID: 28329
		internal static byte __PropertyMask_bGroup16;

		// Token: 0x04006EAA RID: 28330
		internal static int __PropertyOffset_bGroup17;

		// Token: 0x04006EAB RID: 28331
		internal static byte __PropertyMask_bGroup17;

		// Token: 0x04006EAC RID: 28332
		internal static int __PropertyOffset_bGroup18;

		// Token: 0x04006EAD RID: 28333
		internal static byte __PropertyMask_bGroup18;

		// Token: 0x04006EAE RID: 28334
		internal static int __PropertyOffset_bGroup19;

		// Token: 0x04006EAF RID: 28335
		internal static byte __PropertyMask_bGroup19;

		// Token: 0x04006EB0 RID: 28336
		internal static int __PropertyOffset_bGroup20;

		// Token: 0x04006EB1 RID: 28337
		internal static byte __PropertyMask_bGroup20;

		// Token: 0x04006EB2 RID: 28338
		internal static int __PropertyOffset_bGroup21;

		// Token: 0x04006EB3 RID: 28339
		internal static byte __PropertyMask_bGroup21;

		// Token: 0x04006EB4 RID: 28340
		internal static int __PropertyOffset_bGroup22;

		// Token: 0x04006EB5 RID: 28341
		internal static byte __PropertyMask_bGroup22;

		// Token: 0x04006EB6 RID: 28342
		internal static int __PropertyOffset_bGroup23;

		// Token: 0x04006EB7 RID: 28343
		internal static byte __PropertyMask_bGroup23;

		// Token: 0x04006EB8 RID: 28344
		internal static int __PropertyOffset_bGroup24;

		// Token: 0x04006EB9 RID: 28345
		internal static byte __PropertyMask_bGroup24;

		// Token: 0x04006EBA RID: 28346
		internal static int __PropertyOffset_bGroup25;

		// Token: 0x04006EBB RID: 28347
		internal static byte __PropertyMask_bGroup25;

		// Token: 0x04006EBC RID: 28348
		internal static int __PropertyOffset_bGroup26;

		// Token: 0x04006EBD RID: 28349
		internal static byte __PropertyMask_bGroup26;

		// Token: 0x04006EBE RID: 28350
		internal static int __PropertyOffset_bGroup27;

		// Token: 0x04006EBF RID: 28351
		internal static byte __PropertyMask_bGroup27;

		// Token: 0x04006EC0 RID: 28352
		internal static int __PropertyOffset_bGroup28;

		// Token: 0x04006EC1 RID: 28353
		internal static byte __PropertyMask_bGroup28;

		// Token: 0x04006EC2 RID: 28354
		internal static int __PropertyOffset_bGroup29;

		// Token: 0x04006EC3 RID: 28355
		internal static byte __PropertyMask_bGroup29;

		// Token: 0x04006EC4 RID: 28356
		internal static int __PropertyOffset_bGroup30;

		// Token: 0x04006EC5 RID: 28357
		internal static byte __PropertyMask_bGroup30;

		// Token: 0x04006EC6 RID: 28358
		internal static int __PropertyOffset_bGroup31;

		// Token: 0x04006EC7 RID: 28359
		internal static byte __PropertyMask_bGroup31;
	}
}
