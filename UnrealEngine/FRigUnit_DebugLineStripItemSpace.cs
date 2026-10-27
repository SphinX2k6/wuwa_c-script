using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058A RID: 1418
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugLineStripItemSpace")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FRigUnit_DebugLineStripItemSpace : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004BB5 RID: 19381 RVA: 0x0007022F File Offset: 0x0006E42F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugLineStripItemSpace._ScriptStructPtr != 0) ? FRigUnit_DebugLineStripItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugLineStripItemSpace", ref FRigUnit_DebugLineStripItemSpace._ScriptStructPtr);
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x00070254 File Offset: 0x0006E454
		// (set) Token: 0x06004BB7 RID: 19383 RVA: 0x00070297 File Offset: 0x0006E497
		public TArray<FVector> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06004BB8 RID: 19384 RVA: 0x000702A5 File Offset: 0x0006E4A5
		// (set) Token: 0x06004BB9 RID: 19385 RVA: 0x000702B9 File Offset: 0x0006E4B9
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x000702CE File Offset: 0x0006E4CE
		// (set) Token: 0x06004BBB RID: 19387 RVA: 0x000702DE File Offset: 0x0006E4DE
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06004BBC RID: 19388 RVA: 0x000702F0 File Offset: 0x0006E4F0
		// (set) Token: 0x06004BBD RID: 19389 RVA: 0x00070333 File Offset: 0x0006E533
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x00070354 File Offset: 0x0006E554
		// (set) Token: 0x06004BBF RID: 19391 RVA: 0x00070368 File Offset: 0x0006E568
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x0007037D File Offset: 0x0006E57D
		// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x0007038D File Offset: 0x0006E58D
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStripItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x0007039E File Offset: 0x0006E59E
		public FRigUnit_DebugLineStripItemSpace()
		{
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x000703A6 File Offset: 0x0006E5A6
		public FRigUnit_DebugLineStripItemSpace(TArray<FVector> Points, FLinearColor Color, float Thickness, FRigElementKey Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Points = Points;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x000703E3 File Offset: 0x0006E5E3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugLineStripItemSpace.StaticStruct();
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x000703EF File Offset: 0x0006E5EF
		[NullableContext(2)]
		public FRigUnit_DebugLineStripItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x000703F9 File Offset: 0x0006E5F9
		public FRigUnit_DebugLineStripItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00070404 File Offset: 0x0006E604
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugLineStripItemSpace(Pointer, false, true);
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x0007040E File Offset: 0x0006E60E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugLineStripItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x040024AA RID: 9386
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugLineStripItemSpace";

		// Token: 0x040024AB RID: 9387
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024AC RID: 9388
		internal static int __PropertyOffset_Points;

		// Token: 0x040024AD RID: 9389
		[Nullable(2)]
		private TArray<FVector> _Points;

		// Token: 0x040024AE RID: 9390
		internal static int __PropertyOffset_Color;

		// Token: 0x040024AF RID: 9391
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024B0 RID: 9392
		internal static int __PropertyOffset_Space;

		// Token: 0x040024B1 RID: 9393
		[Nullable(2)]
		private FRigElementKey _Space;

		// Token: 0x040024B2 RID: 9394
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024B3 RID: 9395
		internal static int __PropertyOffset_bEnabled;
	}
}
