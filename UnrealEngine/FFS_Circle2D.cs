using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A97 RID: 6807
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FS_Circle2D")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FFS_Circle2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060191BC RID: 102844 RVA: 0x00251C1D File Offset: 0x0024FE1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFS_Circle2D._ScriptStructPtr != 0) ? FFS_Circle2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.FS_Circle2D", ref FFS_Circle2D._ScriptStructPtr);
		}

		// Token: 0x170063BA RID: 25530
		// (get) Token: 0x060191BD RID: 102845 RVA: 0x00251C41 File Offset: 0x0024FE41
		// (set) Token: 0x060191BE RID: 102846 RVA: 0x00251C55 File Offset: 0x0024FE55
		public unsafe FVector2D Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_Circle2D.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_Circle2D.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x170063BB RID: 25531
		// (get) Token: 0x060191BF RID: 102847 RVA: 0x00251C6A File Offset: 0x0024FE6A
		// (set) Token: 0x060191C0 RID: 102848 RVA: 0x00251C7A File Offset: 0x0024FE7A
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_Circle2D.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_Circle2D.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x060191C1 RID: 102849 RVA: 0x00251C8B File Offset: 0x0024FE8B
		public FFS_Circle2D()
		{
		}

		// Token: 0x060191C2 RID: 102850 RVA: 0x00251C93 File Offset: 0x0024FE93
		public FFS_Circle2D(FVector2D Center, float Radius)
		{
			this.Center = Center;
			this.Radius = Radius;
		}

		// Token: 0x060191C3 RID: 102851 RVA: 0x00251CA9 File Offset: 0x0024FEA9
		protected override IntPtr GetUStructPtr()
		{
			return FFS_Circle2D.StaticStruct();
		}

		// Token: 0x060191C4 RID: 102852 RVA: 0x00251CB5 File Offset: 0x0024FEB5
		[NullableContext(2)]
		public FFS_Circle2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060191C5 RID: 102853 RVA: 0x00251CBF File Offset: 0x0024FEBF
		public FFS_Circle2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060191C6 RID: 102854 RVA: 0x00251CCA File Offset: 0x0024FECA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFS_Circle2D(Pointer, false, true);
		}

		// Token: 0x060191C7 RID: 102855 RVA: 0x00251CD4 File Offset: 0x0024FED4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFS_Circle2D(Pointer, MemoryOwner);
		}

		// Token: 0x0400DAED RID: 56045
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FS_Circle2D";

		// Token: 0x0400DAEE RID: 56046
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DAEF RID: 56047
		internal static int __PropertyOffset_Center;

		// Token: 0x0400DAF0 RID: 56048
		internal static int __PropertyOffset_Radius;
	}
}
