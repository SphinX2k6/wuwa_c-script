using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B7E RID: 7038
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecoration")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroNpcExtraDecoration : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AB4C RID: 109388 RVA: 0x002759FA File Offset: 0x00273BFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNpcExtraDecoration._ScriptStructPtr != 0) ? FKuroNpcExtraDecoration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecoration", ref FKuroNpcExtraDecoration._ScriptStructPtr);
		}

		// Token: 0x17006B68 RID: 27496
		// (get) Token: 0x0601AB4D RID: 109389 RVA: 0x00275A1E File Offset: 0x00273C1E
		// (set) Token: 0x0601AB4E RID: 109390 RVA: 0x00275A32 File Offset: 0x00273C32
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17006B69 RID: 27497
		// (get) Token: 0x0601AB4F RID: 109391 RVA: 0x00275A47 File Offset: 0x00273C47
		// (set) Token: 0x0601AB50 RID: 109392 RVA: 0x00275A57 File Offset: 0x00273C57
		public unsafe EKuroNpcAttachType AttachType
		{
			get
			{
				return (EKuroNpcAttachType)(*(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_AttachType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_AttachType) = (byte)value;
			}
		}

		// Token: 0x17006B6A RID: 27498
		// (get) Token: 0x0601AB51 RID: 109393 RVA: 0x00275A68 File Offset: 0x00273C68
		// (set) Token: 0x0601AB52 RID: 109394 RVA: 0x00275A78 File Offset: 0x00273C78
		public unsafe EKuroNpcExtraDecorationType Type
		{
			get
			{
				return (EKuroNpcExtraDecorationType)(*(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17006B6B RID: 27499
		// (get) Token: 0x0601AB53 RID: 109395 RVA: 0x00275A89 File Offset: 0x00273C89
		// (set) Token: 0x0601AB54 RID: 109396 RVA: 0x00275A9D File Offset: 0x00273C9D
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroNpcExtraDecoration.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroNpcExtraDecoration.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17006B6C RID: 27500
		// (get) Token: 0x0601AB55 RID: 109397 RVA: 0x00275AB2 File Offset: 0x00273CB2
		// (set) Token: 0x0601AB56 RID: 109398 RVA: 0x00275AC6 File Offset: 0x00273CC6
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17006B6D RID: 27501
		// (get) Token: 0x0601AB57 RID: 109399 RVA: 0x00275ADC File Offset: 0x00273CDC
		// (set) Token: 0x0601AB58 RID: 109400 RVA: 0x00275B1F File Offset: 0x00273D1F
		public TArray<FKuroNpcExtraDecorationMorphTargetItem> MorphTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroNpcExtraDecorationMorphTargetItem> result;
				if ((result = this._MorphTargets) == null)
				{
					result = (this._MorphTargets = new TArray<FKuroNpcExtraDecorationMorphTargetItem>(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_MorphTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MorphTargets.CopyAssign(value);
			}
		}

		// Token: 0x17006B6E RID: 27502
		// (get) Token: 0x0601AB59 RID: 109401 RVA: 0x00275B30 File Offset: 0x00273D30
		// (set) Token: 0x0601AB5A RID: 109402 RVA: 0x00275B73 File Offset: 0x00273D73
		public TArray<FKuroNpcExtraDecorationMaterialItem> ReplaceMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroNpcExtraDecorationMaterialItem> result;
				if ((result = this._ReplaceMaterials) == null)
				{
					result = (this._ReplaceMaterials = new TArray<FKuroNpcExtraDecorationMaterialItem>(base.NativePtr + (IntPtr)FKuroNpcExtraDecoration.__PropertyOffset_ReplaceMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplaceMaterials.CopyAssign(value);
			}
		}

		// Token: 0x0601AB5B RID: 109403 RVA: 0x00275B81 File Offset: 0x00273D81
		public FKuroNpcExtraDecoration()
		{
		}

		// Token: 0x0601AB5C RID: 109404 RVA: 0x00275B89 File Offset: 0x00273D89
		public FKuroNpcExtraDecoration(FName SocketName, EKuroNpcAttachType AttachType, EKuroNpcExtraDecorationType Type, USkeletalMesh Mesh, FTransform Transform, TArray<FKuroNpcExtraDecorationMorphTargetItem> MorphTargets, TArray<FKuroNpcExtraDecorationMaterialItem> ReplaceMaterials)
		{
			this.SocketName = SocketName;
			this.AttachType = AttachType;
			this.Type = Type;
			this.Mesh = Mesh;
			this.Transform = Transform;
			this.MorphTargets = MorphTargets;
			this.ReplaceMaterials = ReplaceMaterials;
		}

		// Token: 0x0601AB5D RID: 109405 RVA: 0x00275BC6 File Offset: 0x00273DC6
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNpcExtraDecoration.StaticStruct();
		}

		// Token: 0x0601AB5E RID: 109406 RVA: 0x00275BD2 File Offset: 0x00273DD2
		[NullableContext(2)]
		public FKuroNpcExtraDecoration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AB5F RID: 109407 RVA: 0x00275BDC File Offset: 0x00273DDC
		public FKuroNpcExtraDecoration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AB60 RID: 109408 RVA: 0x00275BE7 File Offset: 0x00273DE7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNpcExtraDecoration(Pointer, false, true);
		}

		// Token: 0x0601AB61 RID: 109409 RVA: 0x00275BF1 File Offset: 0x00273DF1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNpcExtraDecoration(Pointer, MemoryOwner);
		}

		// Token: 0x0400E72A RID: 59178
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecoration";

		// Token: 0x0400E72B RID: 59179
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E72C RID: 59180
		internal static int __PropertyOffset_SocketName;

		// Token: 0x0400E72D RID: 59181
		internal static int __PropertyOffset_AttachType;

		// Token: 0x0400E72E RID: 59182
		internal static int __PropertyOffset_Type;

		// Token: 0x0400E72F RID: 59183
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400E730 RID: 59184
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400E731 RID: 59185
		internal static int __PropertyOffset_MorphTargets;

		// Token: 0x0400E732 RID: 59186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroNpcExtraDecorationMorphTargetItem> _MorphTargets;

		// Token: 0x0400E733 RID: 59187
		internal static int __PropertyOffset_ReplaceMaterials;

		// Token: 0x0400E734 RID: 59188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroNpcExtraDecorationMaterialItem> _ReplaceMaterials;
	}
}
