using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002692 RID: 9874
	[UnrealObjectPath("/Script/Renderer.MyQuad")]
	[UnrealStructLayout(128, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FMyQuad : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024A7D RID: 150141 RVA: 0x0036454C File Offset: 0x0036274C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMyQuad._ScriptStructPtr != 0) ? FMyQuad._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.MyQuad", ref FMyQuad._ScriptStructPtr);
		}

		// Token: 0x17008D5E RID: 36190
		// (get) Token: 0x06024A7E RID: 150142 RVA: 0x00364570 File Offset: 0x00362770
		// (set) Token: 0x06024A7F RID: 150143 RVA: 0x00364584 File Offset: 0x00362784
		public unsafe FVector p0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p0) = value;
			}
		}

		// Token: 0x17008D5F RID: 36191
		// (get) Token: 0x06024A80 RID: 150144 RVA: 0x00364599 File Offset: 0x00362799
		// (set) Token: 0x06024A81 RID: 150145 RVA: 0x003645AD File Offset: 0x003627AD
		public unsafe FVector p1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p1) = value;
			}
		}

		// Token: 0x17008D60 RID: 36192
		// (get) Token: 0x06024A82 RID: 150146 RVA: 0x003645C2 File Offset: 0x003627C2
		// (set) Token: 0x06024A83 RID: 150147 RVA: 0x003645D6 File Offset: 0x003627D6
		public unsafe FVector p2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p2) = value;
			}
		}

		// Token: 0x17008D61 RID: 36193
		// (get) Token: 0x06024A84 RID: 150148 RVA: 0x003645EB File Offset: 0x003627EB
		// (set) Token: 0x06024A85 RID: 150149 RVA: 0x003645FF File Offset: 0x003627FF
		public unsafe FVector p3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_p3) = value;
			}
		}

		// Token: 0x17008D62 RID: 36194
		// (get) Token: 0x06024A86 RID: 150150 RVA: 0x00364614 File Offset: 0x00362814
		// (set) Token: 0x06024A87 RID: 150151 RVA: 0x00364628 File Offset: 0x00362828
		public unsafe FVector n0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n0) = value;
			}
		}

		// Token: 0x17008D63 RID: 36195
		// (get) Token: 0x06024A88 RID: 150152 RVA: 0x0036463D File Offset: 0x0036283D
		// (set) Token: 0x06024A89 RID: 150153 RVA: 0x00364651 File Offset: 0x00362851
		public unsafe FVector n1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n1) = value;
			}
		}

		// Token: 0x17008D64 RID: 36196
		// (get) Token: 0x06024A8A RID: 150154 RVA: 0x00364666 File Offset: 0x00362866
		// (set) Token: 0x06024A8B RID: 150155 RVA: 0x0036467A File Offset: 0x0036287A
		public unsafe FVector n2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n2) = value;
			}
		}

		// Token: 0x17008D65 RID: 36197
		// (get) Token: 0x06024A8C RID: 150156 RVA: 0x0036468F File Offset: 0x0036288F
		// (set) Token: 0x06024A8D RID: 150157 RVA: 0x003646A3 File Offset: 0x003628A3
		public unsafe FVector n3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyQuad.__PropertyOffset_n3) = value;
			}
		}

		// Token: 0x06024A8E RID: 150158 RVA: 0x003646B8 File Offset: 0x003628B8
		public FMyQuad()
		{
		}

		// Token: 0x06024A8F RID: 150159 RVA: 0x003646C0 File Offset: 0x003628C0
		public FMyQuad(FVector p0, FVector p1, FVector p2, FVector p3, FVector n0, FVector n1, FVector n2, FVector n3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.n0 = n0;
			this.n1 = n1;
			this.n2 = n2;
			this.n3 = n3;
		}

		// Token: 0x06024A90 RID: 150160 RVA: 0x00364710 File Offset: 0x00362910
		protected override IntPtr GetUStructPtr()
		{
			return FMyQuad.StaticStruct();
		}

		// Token: 0x06024A91 RID: 150161 RVA: 0x0036471C File Offset: 0x0036291C
		[NullableContext(2)]
		public FMyQuad(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024A92 RID: 150162 RVA: 0x00364726 File Offset: 0x00362926
		public FMyQuad(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024A93 RID: 150163 RVA: 0x00364731 File Offset: 0x00362931
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMyQuad(Pointer, false, true);
		}

		// Token: 0x06024A94 RID: 150164 RVA: 0x0036473B File Offset: 0x0036293B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMyQuad(Pointer, MemoryOwner);
		}

		// Token: 0x04013B5C RID: 80732
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.MyQuad";

		// Token: 0x04013B5D RID: 80733
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B5E RID: 80734
		internal static int __PropertyOffset_p0;

		// Token: 0x04013B5F RID: 80735
		internal static int __PropertyOffset_p1;

		// Token: 0x04013B60 RID: 80736
		internal static int __PropertyOffset_p2;

		// Token: 0x04013B61 RID: 80737
		internal static int __PropertyOffset_p3;

		// Token: 0x04013B62 RID: 80738
		internal static int __PropertyOffset_n0;

		// Token: 0x04013B63 RID: 80739
		internal static int __PropertyOffset_n1;

		// Token: 0x04013B64 RID: 80740
		internal static int __PropertyOffset_n2;

		// Token: 0x04013B65 RID: 80741
		internal static int __PropertyOffset_n3;
	}
}
