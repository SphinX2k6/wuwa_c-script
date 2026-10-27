using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000546 RID: 1350
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimItem_Target")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_AimItem_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004724 RID: 18212 RVA: 0x00069AE4 File Offset: 0x00067CE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimItem_Target._ScriptStructPtr != 0) ? FRigUnit_AimItem_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimItem_Target", ref FRigUnit_AimItem_Target._ScriptStructPtr);
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x00069B08 File Offset: 0x00067D08
		// (set) Token: 0x06004726 RID: 18214 RVA: 0x00069B18 File Offset: 0x00067D18
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x00069B29 File Offset: 0x00067D29
		// (set) Token: 0x06004728 RID: 18216 RVA: 0x00069B3D File Offset: 0x00067D3D
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x00069B52 File Offset: 0x00067D52
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x00069B66 File Offset: 0x00067D66
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x00069B7B File Offset: 0x00067D7B
		// (set) Token: 0x0600472C RID: 18220 RVA: 0x00069B8B File Offset: 0x00067D8B
		public unsafe EControlRigVectorKind Kind
		{
			get
			{
				return (EControlRigVectorKind)(*(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Kind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Kind) = (byte)value;
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x0600472D RID: 18221 RVA: 0x00069B9C File Offset: 0x00067D9C
		// (set) Token: 0x0600472E RID: 18222 RVA: 0x00069BDF File Offset: 0x00067DDF
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimItem_Target.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x00069C00 File Offset: 0x00067E00
		public FRigUnit_AimItem_Target()
		{
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x00069C08 File Offset: 0x00067E08
		public FRigUnit_AimItem_Target(float Weight, FVector Axis, FVector Target, EControlRigVectorKind Kind, FRigElementKey Space)
		{
			this.Weight = Weight;
			this.Axis = Axis;
			this.Target = Target;
			this.Kind = Kind;
			this.Space = Space;
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x00069C35 File Offset: 0x00067E35
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimItem_Target.StaticStruct();
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x00069C41 File Offset: 0x00067E41
		[NullableContext(2)]
		public FRigUnit_AimItem_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x00069C4B File Offset: 0x00067E4B
		public FRigUnit_AimItem_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x00069C56 File Offset: 0x00067E56
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimItem_Target(Pointer, false, true);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x00069C60 File Offset: 0x00067E60
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimItem_Target(Pointer, MemoryOwner);
		}

		// Token: 0x04002292 RID: 8850
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_AimItem_Target";

		// Token: 0x04002293 RID: 8851
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002294 RID: 8852
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002295 RID: 8853
		internal static int __PropertyOffset_Axis;

		// Token: 0x04002296 RID: 8854
		internal static int __PropertyOffset_Target;

		// Token: 0x04002297 RID: 8855
		internal static int __PropertyOffset_Kind;

		// Token: 0x04002298 RID: 8856
		internal static int __PropertyOffset_Space;

		// Token: 0x04002299 RID: 8857
		[Nullable(2)]
		private FRigElementKey _Space;
	}
}
