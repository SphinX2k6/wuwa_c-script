using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A3B RID: 6715
	[UnrealObjectPath("/Script/KuroPointCloud.PointData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPointData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018DC1 RID: 101825 RVA: 0x0024B8B4 File Offset: 0x00249AB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointData._ScriptStructPtr != 0) ? FPointData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.PointData", ref FPointData._ScriptStructPtr);
		}

		// Token: 0x17006276 RID: 25206
		// (get) Token: 0x06018DC2 RID: 101826 RVA: 0x0024B8D8 File Offset: 0x00249AD8
		// (set) Token: 0x06018DC3 RID: 101827 RVA: 0x0024B8E8 File Offset: 0x00249AE8
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointData.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointData.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x17006277 RID: 25207
		// (get) Token: 0x06018DC4 RID: 101828 RVA: 0x0024B8F9 File Offset: 0x00249AF9
		// (set) Token: 0x06018DC5 RID: 101829 RVA: 0x0024B90D File Offset: 0x00249B0D
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointData.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointData.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x06018DC6 RID: 101830 RVA: 0x0024B922 File Offset: 0x00249B22
		public FPointData()
		{
		}

		// Token: 0x06018DC7 RID: 101831 RVA: 0x0024B92A File Offset: 0x00249B2A
		public FPointData(int Index, FVector Position)
		{
			this.Index = Index;
			this.Position = Position;
		}

		// Token: 0x06018DC8 RID: 101832 RVA: 0x0024B940 File Offset: 0x00249B40
		protected override IntPtr GetUStructPtr()
		{
			return FPointData.StaticStruct();
		}

		// Token: 0x06018DC9 RID: 101833 RVA: 0x0024B94C File Offset: 0x00249B4C
		[NullableContext(2)]
		public FPointData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018DCA RID: 101834 RVA: 0x0024B956 File Offset: 0x00249B56
		public FPointData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018DCB RID: 101835 RVA: 0x0024B961 File Offset: 0x00249B61
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointData(Pointer, false, true);
		}

		// Token: 0x06018DCC RID: 101836 RVA: 0x0024B96B File Offset: 0x00249B6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D6DF RID: 55007
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPointCloud.PointData";

		// Token: 0x0400D6E0 RID: 55008
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D6E1 RID: 55009
		internal static int __PropertyOffset_Index;

		// Token: 0x0400D6E2 RID: 55010
		internal static int __PropertyOffset_Position;
	}
}
