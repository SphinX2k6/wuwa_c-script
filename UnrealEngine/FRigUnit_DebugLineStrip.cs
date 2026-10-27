using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000589 RID: 1417
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugLineStrip")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_DebugLineStrip : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004BA1 RID: 19361 RVA: 0x00070084 File Offset: 0x0006E284
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugLineStrip._ScriptStructPtr != 0) ? FRigUnit_DebugLineStrip._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugLineStrip", ref FRigUnit_DebugLineStrip._ScriptStructPtr);
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06004BA2 RID: 19362 RVA: 0x000700A8 File Offset: 0x0006E2A8
		// (set) Token: 0x06004BA3 RID: 19363 RVA: 0x000700EB File Offset: 0x0006E2EB
		public TArray<FVector> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x000700F9 File Offset: 0x0006E2F9
		// (set) Token: 0x06004BA5 RID: 19365 RVA: 0x0007010D File Offset: 0x0006E30D
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x00070122 File Offset: 0x0006E322
		// (set) Token: 0x06004BA7 RID: 19367 RVA: 0x00070132 File Offset: 0x0006E332
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06004BA8 RID: 19368 RVA: 0x00070143 File Offset: 0x0006E343
		// (set) Token: 0x06004BA9 RID: 19369 RVA: 0x00070157 File Offset: 0x0006E357
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x0007016C File Offset: 0x0006E36C
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x00070180 File Offset: 0x0006E380
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x00070195 File Offset: 0x0006E395
		// (set) Token: 0x06004BAD RID: 19373 RVA: 0x000701A5 File Offset: 0x0006E3A5
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineStrip.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x000701B6 File Offset: 0x0006E3B6
		public FRigUnit_DebugLineStrip()
		{
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x000701BE File Offset: 0x0006E3BE
		public FRigUnit_DebugLineStrip(TArray<FVector> Points, FLinearColor Color, float Thickness, FName Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Points = Points;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x000701FB File Offset: 0x0006E3FB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugLineStrip.StaticStruct();
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x00070207 File Offset: 0x0006E407
		[NullableContext(2)]
		public FRigUnit_DebugLineStrip(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00070211 File Offset: 0x0006E411
		public FRigUnit_DebugLineStrip(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x0007021C File Offset: 0x0006E41C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugLineStrip(Pointer, false, true);
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x00070226 File Offset: 0x0006E426
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugLineStrip(Pointer, MemoryOwner);
		}

		// Token: 0x040024A1 RID: 9377
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugLineStrip";

		// Token: 0x040024A2 RID: 9378
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024A3 RID: 9379
		internal static int __PropertyOffset_Points;

		// Token: 0x040024A4 RID: 9380
		[Nullable(2)]
		private TArray<FVector> _Points;

		// Token: 0x040024A5 RID: 9381
		internal static int __PropertyOffset_Color;

		// Token: 0x040024A6 RID: 9382
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024A7 RID: 9383
		internal static int __PropertyOffset_Space;

		// Token: 0x040024A8 RID: 9384
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024A9 RID: 9385
		internal static int __PropertyOffset_bEnabled;
	}
}
