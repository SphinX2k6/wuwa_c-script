using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B1A RID: 6938
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInstanceInfo")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroGrassInstanceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A1B7 RID: 106935 RVA: 0x00268899 File Offset: 0x00266A99
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGrassInstanceInfo._ScriptStructPtr != 0) ? FKuroGrassInstanceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInstanceInfo", ref FKuroGrassInstanceInfo._ScriptStructPtr);
		}

		// Token: 0x170068D5 RID: 26837
		// (get) Token: 0x0601A1B8 RID: 106936 RVA: 0x002688BD File Offset: 0x00266ABD
		// (set) Token: 0x0601A1B9 RID: 106937 RVA: 0x002688D1 File Offset: 0x00266AD1
		public unsafe FMatrix TransformMatrix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGrassInstanceInfo.__PropertyOffset_TransformMatrix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGrassInstanceInfo.__PropertyOffset_TransformMatrix) = value;
			}
		}

		// Token: 0x170068D6 RID: 26838
		// (get) Token: 0x0601A1BA RID: 106938 RVA: 0x002688E6 File Offset: 0x00266AE6
		// (set) Token: 0x0601A1BB RID: 106939 RVA: 0x002688F6 File Offset: 0x00266AF6
		public unsafe float RandomValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGrassInstanceInfo.__PropertyOffset_RandomValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGrassInstanceInfo.__PropertyOffset_RandomValue) = value;
			}
		}

		// Token: 0x0601A1BC RID: 106940 RVA: 0x00268907 File Offset: 0x00266B07
		public FKuroGrassInstanceInfo()
		{
		}

		// Token: 0x0601A1BD RID: 106941 RVA: 0x0026890F File Offset: 0x00266B0F
		public FKuroGrassInstanceInfo(FMatrix TransformMatrix, float RandomValue)
		{
			this.TransformMatrix = TransformMatrix;
			this.RandomValue = RandomValue;
		}

		// Token: 0x0601A1BE RID: 106942 RVA: 0x00268925 File Offset: 0x00266B25
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGrassInstanceInfo.StaticStruct();
		}

		// Token: 0x0601A1BF RID: 106943 RVA: 0x00268931 File Offset: 0x00266B31
		[NullableContext(2)]
		public FKuroGrassInstanceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A1C0 RID: 106944 RVA: 0x0026893B File Offset: 0x00266B3B
		public FKuroGrassInstanceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A1C1 RID: 106945 RVA: 0x00268946 File Offset: 0x00266B46
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGrassInstanceInfo(Pointer, false, true);
		}

		// Token: 0x0601A1C2 RID: 106946 RVA: 0x00268950 File Offset: 0x00266B50
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGrassInstanceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400E2D5 RID: 58069
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGrassInstanceInfo";

		// Token: 0x0400E2D6 RID: 58070
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E2D7 RID: 58071
		internal static int __PropertyOffset_TransformMatrix;

		// Token: 0x0400E2D8 RID: 58072
		internal static int __PropertyOffset_RandomValue;
	}
}
