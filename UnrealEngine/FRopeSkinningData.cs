using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C7A RID: 7290
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeSkinningData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRopeSkinningData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C494 RID: 115860 RVA: 0x0029B3E6 File Offset: 0x002995E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRopeSkinningData._ScriptStructPtr != 0) ? FRopeSkinningData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRopeEffect.RopeSkinningData", ref FRopeSkinningData._ScriptStructPtr);
		}

		// Token: 0x17007257 RID: 29271
		// (get) Token: 0x0601C495 RID: 115861 RVA: 0x0029B40C File Offset: 0x0029960C
		// (set) Token: 0x0601C496 RID: 115862 RVA: 0x0029B44F File Offset: 0x0029964F
		public TArray<FRopeControlPointSkinning> ControlPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRopeControlPointSkinning> result;
				if ((result = this._ControlPoints) == null)
				{
					result = (this._ControlPoints = new TArray<FRopeControlPointSkinning>(base.NativePtr + (IntPtr)FRopeSkinningData.__PropertyOffset_ControlPoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ControlPoints.CopyAssign(value);
			}
		}

		// Token: 0x17007258 RID: 29272
		// (get) Token: 0x0601C497 RID: 115863 RVA: 0x0029B460 File Offset: 0x00299660
		// (set) Token: 0x0601C498 RID: 115864 RVA: 0x0029B4A3 File Offset: 0x002996A3
		public TArray<FVector> LastWorldPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._LastWorldPositions) == null)
				{
					result = (this._LastWorldPositions = new TArray<FVector>(base.NativePtr + (IntPtr)FRopeSkinningData.__PropertyOffset_LastWorldPositions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LastWorldPositions.CopyAssign(value);
			}
		}

		// Token: 0x0601C499 RID: 115865 RVA: 0x0029B4B1 File Offset: 0x002996B1
		public FRopeSkinningData()
		{
		}

		// Token: 0x0601C49A RID: 115866 RVA: 0x0029B4B9 File Offset: 0x002996B9
		public FRopeSkinningData(TArray<FRopeControlPointSkinning> ControlPoints, TArray<FVector> LastWorldPositions)
		{
			this.ControlPoints = ControlPoints;
			this.LastWorldPositions = LastWorldPositions;
		}

		// Token: 0x0601C49B RID: 115867 RVA: 0x0029B4CF File Offset: 0x002996CF
		protected override IntPtr GetUStructPtr()
		{
			return FRopeSkinningData.StaticStruct();
		}

		// Token: 0x0601C49C RID: 115868 RVA: 0x0029B4DB File Offset: 0x002996DB
		[NullableContext(2)]
		public FRopeSkinningData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C49D RID: 115869 RVA: 0x0029B4E5 File Offset: 0x002996E5
		public FRopeSkinningData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C49E RID: 115870 RVA: 0x0029B4F0 File Offset: 0x002996F0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRopeSkinningData(Pointer, false, true);
		}

		// Token: 0x0601C49F RID: 115871 RVA: 0x0029B4FA File Offset: 0x002996FA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRopeSkinningData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F35E RID: 62302
		public const string __ObjectPath = "/Script/KuroRopeEffect.RopeSkinningData";

		// Token: 0x0400F35F RID: 62303
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F360 RID: 62304
		internal static int __PropertyOffset_ControlPoints;

		// Token: 0x0400F361 RID: 62305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRopeControlPointSkinning> _ControlPoints;

		// Token: 0x0400F362 RID: 62306
		internal static int __PropertyOffset_LastWorldPositions;

		// Token: 0x0400F363 RID: 62307
		[Nullable(2)]
		private TArray<FVector> _LastWorldPositions;
	}
}
