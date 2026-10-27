using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002476 RID: 9334
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavArea")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UNavArea : UNavAreaBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022EDC RID: 143068 RVA: 0x0033A32F File Offset: 0x0033852F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea._ClassPtr;
		}

		// Token: 0x17008628 RID: 34344
		// (get) Token: 0x06022EDD RID: 143069 RVA: 0x0033A33B File Offset: 0x0033853B
		// (set) Token: 0x06022EDE RID: 143070 RVA: 0x0033A34B File Offset: 0x0033854B
		public unsafe float DefaultCost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_DefaultCost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_DefaultCost) = value;
			}
		}

		// Token: 0x17008629 RID: 34345
		// (get) Token: 0x06022EDF RID: 143071 RVA: 0x0033A35C File Offset: 0x0033855C
		// (set) Token: 0x06022EE0 RID: 143072 RVA: 0x0033A36C File Offset: 0x0033856C
		public unsafe float FixedAreaEnteringCost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_FixedAreaEnteringCost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_FixedAreaEnteringCost) = value;
			}
		}

		// Token: 0x1700862A RID: 34346
		// (get) Token: 0x06022EE1 RID: 143073 RVA: 0x0033A37D File Offset: 0x0033857D
		// (set) Token: 0x06022EE2 RID: 143074 RVA: 0x0033A391 File Offset: 0x00338591
		public unsafe FColor DrawColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_DrawColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_DrawColor) = value;
			}
		}

		// Token: 0x1700862B RID: 34347
		// (get) Token: 0x06022EE3 RID: 143075 RVA: 0x0033A3A8 File Offset: 0x003385A8
		// (set) Token: 0x06022EE4 RID: 143076 RVA: 0x0033A3E1 File Offset: 0x003385E1
		public FNavAgentSelector SupportedAgents
		{
			get
			{
				base.FastCheckIsValid();
				FNavAgentSelector result;
				if ((result = this._SupportedAgents) == null)
				{
					result = (this._SupportedAgents = new FNavAgentSelector(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_SupportedAgents, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentSelector.StaticStruct(), base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_SupportedAgents, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700862C RID: 34348
		// (get) Token: 0x06022EE5 RID: 143077 RVA: 0x0033A402 File Offset: 0x00338602
		// (set) Token: 0x06022EE6 RID: 143078 RVA: 0x0033A41B File Offset: 0x0033861B
		public unsafe bool bSupportsAgent0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent0) & UNavArea.__PropertyMask_bSupportsAgent0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent0) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent0) & ~UNavArea.__PropertyMask_bSupportsAgent0) | (value ? UNavArea.__PropertyMask_bSupportsAgent0 : 0));
			}
		}

		// Token: 0x1700862D RID: 34349
		// (get) Token: 0x06022EE7 RID: 143079 RVA: 0x0033A44B File Offset: 0x0033864B
		// (set) Token: 0x06022EE8 RID: 143080 RVA: 0x0033A464 File Offset: 0x00338664
		public unsafe bool bSupportsAgent1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent1) & UNavArea.__PropertyMask_bSupportsAgent1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent1) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent1) & ~UNavArea.__PropertyMask_bSupportsAgent1) | (value ? UNavArea.__PropertyMask_bSupportsAgent1 : 0));
			}
		}

		// Token: 0x1700862E RID: 34350
		// (get) Token: 0x06022EE9 RID: 143081 RVA: 0x0033A494 File Offset: 0x00338694
		// (set) Token: 0x06022EEA RID: 143082 RVA: 0x0033A4AD File Offset: 0x003386AD
		public unsafe bool bSupportsAgent2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent2) & UNavArea.__PropertyMask_bSupportsAgent2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent2) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent2) & ~UNavArea.__PropertyMask_bSupportsAgent2) | (value ? UNavArea.__PropertyMask_bSupportsAgent2 : 0));
			}
		}

		// Token: 0x1700862F RID: 34351
		// (get) Token: 0x06022EEB RID: 143083 RVA: 0x0033A4DD File Offset: 0x003386DD
		// (set) Token: 0x06022EEC RID: 143084 RVA: 0x0033A4F6 File Offset: 0x003386F6
		public unsafe bool bSupportsAgent3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent3) & UNavArea.__PropertyMask_bSupportsAgent3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent3) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent3) & ~UNavArea.__PropertyMask_bSupportsAgent3) | (value ? UNavArea.__PropertyMask_bSupportsAgent3 : 0));
			}
		}

		// Token: 0x17008630 RID: 34352
		// (get) Token: 0x06022EED RID: 143085 RVA: 0x0033A526 File Offset: 0x00338726
		// (set) Token: 0x06022EEE RID: 143086 RVA: 0x0033A53F File Offset: 0x0033873F
		public unsafe bool bSupportsAgent4
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent4) & UNavArea.__PropertyMask_bSupportsAgent4) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent4) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent4) & ~UNavArea.__PropertyMask_bSupportsAgent4) | (value ? UNavArea.__PropertyMask_bSupportsAgent4 : 0));
			}
		}

		// Token: 0x17008631 RID: 34353
		// (get) Token: 0x06022EEF RID: 143087 RVA: 0x0033A56F File Offset: 0x0033876F
		// (set) Token: 0x06022EF0 RID: 143088 RVA: 0x0033A588 File Offset: 0x00338788
		public unsafe bool bSupportsAgent5
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent5) & UNavArea.__PropertyMask_bSupportsAgent5) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent5) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent5) & ~UNavArea.__PropertyMask_bSupportsAgent5) | (value ? UNavArea.__PropertyMask_bSupportsAgent5 : 0));
			}
		}

		// Token: 0x17008632 RID: 34354
		// (get) Token: 0x06022EF1 RID: 143089 RVA: 0x0033A5B8 File Offset: 0x003387B8
		// (set) Token: 0x06022EF2 RID: 143090 RVA: 0x0033A5D1 File Offset: 0x003387D1
		public unsafe bool bSupportsAgent6
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent6) & UNavArea.__PropertyMask_bSupportsAgent6) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent6) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent6) & ~UNavArea.__PropertyMask_bSupportsAgent6) | (value ? UNavArea.__PropertyMask_bSupportsAgent6 : 0));
			}
		}

		// Token: 0x17008633 RID: 34355
		// (get) Token: 0x06022EF3 RID: 143091 RVA: 0x0033A601 File Offset: 0x00338801
		// (set) Token: 0x06022EF4 RID: 143092 RVA: 0x0033A61A File Offset: 0x0033881A
		public unsafe bool bSupportsAgent7
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent7) & UNavArea.__PropertyMask_bSupportsAgent7) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent7) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent7) & ~UNavArea.__PropertyMask_bSupportsAgent7) | (value ? UNavArea.__PropertyMask_bSupportsAgent7 : 0));
			}
		}

		// Token: 0x17008634 RID: 34356
		// (get) Token: 0x06022EF5 RID: 143093 RVA: 0x0033A64A File Offset: 0x0033884A
		// (set) Token: 0x06022EF6 RID: 143094 RVA: 0x0033A663 File Offset: 0x00338863
		public unsafe bool bSupportsAgent8
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent8) & UNavArea.__PropertyMask_bSupportsAgent8) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent8) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent8) & ~UNavArea.__PropertyMask_bSupportsAgent8) | (value ? UNavArea.__PropertyMask_bSupportsAgent8 : 0));
			}
		}

		// Token: 0x17008635 RID: 34357
		// (get) Token: 0x06022EF7 RID: 143095 RVA: 0x0033A693 File Offset: 0x00338893
		// (set) Token: 0x06022EF8 RID: 143096 RVA: 0x0033A6AC File Offset: 0x003388AC
		public unsafe bool bSupportsAgent9
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent9) & UNavArea.__PropertyMask_bSupportsAgent9) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent9) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent9) & ~UNavArea.__PropertyMask_bSupportsAgent9) | (value ? UNavArea.__PropertyMask_bSupportsAgent9 : 0));
			}
		}

		// Token: 0x17008636 RID: 34358
		// (get) Token: 0x06022EF9 RID: 143097 RVA: 0x0033A6DC File Offset: 0x003388DC
		// (set) Token: 0x06022EFA RID: 143098 RVA: 0x0033A6F5 File Offset: 0x003388F5
		public unsafe bool bSupportsAgent10
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent10) & UNavArea.__PropertyMask_bSupportsAgent10) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent10) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent10) & ~UNavArea.__PropertyMask_bSupportsAgent10) | (value ? UNavArea.__PropertyMask_bSupportsAgent10 : 0));
			}
		}

		// Token: 0x17008637 RID: 34359
		// (get) Token: 0x06022EFB RID: 143099 RVA: 0x0033A725 File Offset: 0x00338925
		// (set) Token: 0x06022EFC RID: 143100 RVA: 0x0033A73E File Offset: 0x0033893E
		public unsafe bool bSupportsAgent11
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent11) & UNavArea.__PropertyMask_bSupportsAgent11) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent11) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent11) & ~UNavArea.__PropertyMask_bSupportsAgent11) | (value ? UNavArea.__PropertyMask_bSupportsAgent11 : 0));
			}
		}

		// Token: 0x17008638 RID: 34360
		// (get) Token: 0x06022EFD RID: 143101 RVA: 0x0033A76E File Offset: 0x0033896E
		// (set) Token: 0x06022EFE RID: 143102 RVA: 0x0033A787 File Offset: 0x00338987
		public unsafe bool bSupportsAgent12
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent12) & UNavArea.__PropertyMask_bSupportsAgent12) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent12) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent12) & ~UNavArea.__PropertyMask_bSupportsAgent12) | (value ? UNavArea.__PropertyMask_bSupportsAgent12 : 0));
			}
		}

		// Token: 0x17008639 RID: 34361
		// (get) Token: 0x06022EFF RID: 143103 RVA: 0x0033A7B7 File Offset: 0x003389B7
		// (set) Token: 0x06022F00 RID: 143104 RVA: 0x0033A7D0 File Offset: 0x003389D0
		public unsafe bool bSupportsAgent13
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent13) & UNavArea.__PropertyMask_bSupportsAgent13) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent13) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent13) & ~UNavArea.__PropertyMask_bSupportsAgent13) | (value ? UNavArea.__PropertyMask_bSupportsAgent13 : 0));
			}
		}

		// Token: 0x1700863A RID: 34362
		// (get) Token: 0x06022F01 RID: 143105 RVA: 0x0033A800 File Offset: 0x00338A00
		// (set) Token: 0x06022F02 RID: 143106 RVA: 0x0033A819 File Offset: 0x00338A19
		public unsafe bool bSupportsAgent14
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent14) & UNavArea.__PropertyMask_bSupportsAgent14) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent14) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent14) & ~UNavArea.__PropertyMask_bSupportsAgent14) | (value ? UNavArea.__PropertyMask_bSupportsAgent14 : 0));
			}
		}

		// Token: 0x1700863B RID: 34363
		// (get) Token: 0x06022F03 RID: 143107 RVA: 0x0033A849 File Offset: 0x00338A49
		// (set) Token: 0x06022F04 RID: 143108 RVA: 0x0033A862 File Offset: 0x00338A62
		public unsafe bool bSupportsAgent15
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent15) & UNavArea.__PropertyMask_bSupportsAgent15) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent15) = ((*(base.NativePtr + (IntPtr)UNavArea.__PropertyOffset_bSupportsAgent15) & ~UNavArea.__PropertyMask_bSupportsAgent15) | (value ? UNavArea.__PropertyMask_bSupportsAgent15 : 0));
			}
		}

		// Token: 0x06022F05 RID: 143109 RVA: 0x0033A892 File Offset: 0x00338A92
		static UNavArea()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea");
		}

		// Token: 0x06022F06 RID: 143110 RVA: 0x0033A8A0 File Offset: 0x00338AA0
		protected UNavArea() : this(BuiltinUtils.AllocNativeUObject(UNavArea.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F07 RID: 143111 RVA: 0x0033A8C8 File Offset: 0x00338AC8
		protected UNavArea(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A5C RID: 76380
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea";

		// Token: 0x04012A5D RID: 76381
		private static IntPtr _ClassPtr;

		// Token: 0x04012A5E RID: 76382
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A5F RID: 76383
		internal static int __PropertyOffset_DefaultCost;

		// Token: 0x04012A60 RID: 76384
		internal static int __PropertyOffset_FixedAreaEnteringCost;

		// Token: 0x04012A61 RID: 76385
		internal static int __PropertyOffset_DrawColor;

		// Token: 0x04012A62 RID: 76386
		internal static int __PropertyOffset_SupportedAgents;

		// Token: 0x04012A63 RID: 76387
		[Nullable(2)]
		private FNavAgentSelector _SupportedAgents;

		// Token: 0x04012A64 RID: 76388
		internal static int __PropertyOffset_bSupportsAgent0;

		// Token: 0x04012A65 RID: 76389
		internal static byte __PropertyMask_bSupportsAgent0;

		// Token: 0x04012A66 RID: 76390
		internal static int __PropertyOffset_bSupportsAgent1;

		// Token: 0x04012A67 RID: 76391
		internal static byte __PropertyMask_bSupportsAgent1;

		// Token: 0x04012A68 RID: 76392
		internal static int __PropertyOffset_bSupportsAgent2;

		// Token: 0x04012A69 RID: 76393
		internal static byte __PropertyMask_bSupportsAgent2;

		// Token: 0x04012A6A RID: 76394
		internal static int __PropertyOffset_bSupportsAgent3;

		// Token: 0x04012A6B RID: 76395
		internal static byte __PropertyMask_bSupportsAgent3;

		// Token: 0x04012A6C RID: 76396
		internal static int __PropertyOffset_bSupportsAgent4;

		// Token: 0x04012A6D RID: 76397
		internal static byte __PropertyMask_bSupportsAgent4;

		// Token: 0x04012A6E RID: 76398
		internal static int __PropertyOffset_bSupportsAgent5;

		// Token: 0x04012A6F RID: 76399
		internal static byte __PropertyMask_bSupportsAgent5;

		// Token: 0x04012A70 RID: 76400
		internal static int __PropertyOffset_bSupportsAgent6;

		// Token: 0x04012A71 RID: 76401
		internal static byte __PropertyMask_bSupportsAgent6;

		// Token: 0x04012A72 RID: 76402
		internal static int __PropertyOffset_bSupportsAgent7;

		// Token: 0x04012A73 RID: 76403
		internal static byte __PropertyMask_bSupportsAgent7;

		// Token: 0x04012A74 RID: 76404
		internal static int __PropertyOffset_bSupportsAgent8;

		// Token: 0x04012A75 RID: 76405
		internal static byte __PropertyMask_bSupportsAgent8;

		// Token: 0x04012A76 RID: 76406
		internal static int __PropertyOffset_bSupportsAgent9;

		// Token: 0x04012A77 RID: 76407
		internal static byte __PropertyMask_bSupportsAgent9;

		// Token: 0x04012A78 RID: 76408
		internal static int __PropertyOffset_bSupportsAgent10;

		// Token: 0x04012A79 RID: 76409
		internal static byte __PropertyMask_bSupportsAgent10;

		// Token: 0x04012A7A RID: 76410
		internal static int __PropertyOffset_bSupportsAgent11;

		// Token: 0x04012A7B RID: 76411
		internal static byte __PropertyMask_bSupportsAgent11;

		// Token: 0x04012A7C RID: 76412
		internal static int __PropertyOffset_bSupportsAgent12;

		// Token: 0x04012A7D RID: 76413
		internal static byte __PropertyMask_bSupportsAgent12;

		// Token: 0x04012A7E RID: 76414
		internal static int __PropertyOffset_bSupportsAgent13;

		// Token: 0x04012A7F RID: 76415
		internal static byte __PropertyMask_bSupportsAgent13;

		// Token: 0x04012A80 RID: 76416
		internal static int __PropertyOffset_bSupportsAgent14;

		// Token: 0x04012A81 RID: 76417
		internal static byte __PropertyMask_bSupportsAgent14;

		// Token: 0x04012A82 RID: 76418
		internal static int __PropertyOffset_bSupportsAgent15;

		// Token: 0x04012A83 RID: 76419
		internal static byte __PropertyMask_bSupportsAgent15;
	}
}
