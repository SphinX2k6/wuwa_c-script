using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002FD RID: 765
	[UnrealObjectPath("/Script/KuroAnim.KuroNpcFootprintEventData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroNpcFootprintEventData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005294 RID: 21140 RVA: 0x000737FE File Offset: 0x000719FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNpcFootprintEventData._ScriptStructPtr != 0) ? FKuroNpcFootprintEventData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroNpcFootprintEventData", ref FKuroNpcFootprintEventData._ScriptStructPtr);
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x00073822 File Offset: 0x00071A22
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x00073832 File Offset: 0x00071A32
		public unsafe int BonePartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcFootprintEventData.__PropertyOffset_BonePartIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcFootprintEventData.__PropertyOffset_BonePartIndex) = value;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x00073843 File Offset: 0x00071A43
		// (set) Token: 0x06005298 RID: 21144 RVA: 0x00073857 File Offset: 0x00071A57
		public unsafe FVectorDouble BoneLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcFootprintEventData.__PropertyOffset_BoneLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcFootprintEventData.__PropertyOffset_BoneLocation) = value;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x0007386C File Offset: 0x00071A6C
		// (set) Token: 0x0600529A RID: 21146 RVA: 0x0007387C File Offset: 0x00071A7C
		public unsafe float GroundHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcFootprintEventData.__PropertyOffset_GroundHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcFootprintEventData.__PropertyOffset_GroundHeight) = value;
			}
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x0007388D File Offset: 0x00071A8D
		public FKuroNpcFootprintEventData()
		{
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00073895 File Offset: 0x00071A95
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNpcFootprintEventData.StaticStruct();
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x000738A1 File Offset: 0x00071AA1
		[NullableContext(2)]
		public FKuroNpcFootprintEventData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x000738AB File Offset: 0x00071AAB
		public FKuroNpcFootprintEventData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x000738B6 File Offset: 0x00071AB6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNpcFootprintEventData(Pointer, false, true);
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x000738C0 File Offset: 0x00071AC0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNpcFootprintEventData(Pointer, MemoryOwner);
		}

		// Token: 0x040021AC RID: 8620
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.KuroNpcFootprintEventData";

		// Token: 0x040021AD RID: 8621
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021AE RID: 8622
		internal static int __PropertyOffset_BonePartIndex;

		// Token: 0x040021AF RID: 8623
		internal static int __PropertyOffset_BoneLocation;

		// Token: 0x040021B0 RID: 8624
		internal static int __PropertyOffset_GroundHeight;
	}
}
