using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002B6 RID: 694
	[UnrealObjectPath("/Script/AnimationCore.Axis")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAxis : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060026AB RID: 9899 RVA: 0x0003A2C2 File Offset: 0x000384C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAxis._ScriptStructPtr != 0) ? FAxis._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.Axis", ref FAxis._ScriptStructPtr);
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x0003A2E6 File Offset: 0x000384E6
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x0003A2FA File Offset: 0x000384FA
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAxis.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAxis.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x0003A30F File Offset: 0x0003850F
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x0003A31F File Offset: 0x0003851F
		public unsafe bool bInLocalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAxis.__PropertyOffset_bInLocalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAxis.__PropertyOffset_bInLocalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x0003A330 File Offset: 0x00038530
		public FAxis()
		{
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x0003A338 File Offset: 0x00038538
		public FAxis(FVector Axis, bool bInLocalSpace)
		{
			this.Axis = Axis;
			this.bInLocalSpace = bInLocalSpace;
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0003A34E File Offset: 0x0003854E
		protected override IntPtr GetUStructPtr()
		{
			return FAxis.StaticStruct();
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x0003A35A File Offset: 0x0003855A
		[NullableContext(2)]
		public FAxis(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x0003A364 File Offset: 0x00038564
		public FAxis(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0003A36F File Offset: 0x0003856F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAxis(Pointer, false, true);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x0003A379 File Offset: 0x00038579
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAxis(Pointer, MemoryOwner);
		}

		// Token: 0x04000F32 RID: 3890
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.Axis";

		// Token: 0x04000F33 RID: 3891
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F34 RID: 3892
		internal static int __PropertyOffset_Axis;

		// Token: 0x04000F35 RID: 3893
		internal static int __PropertyOffset_bInLocalSpace;
	}
}
