using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001380 RID: 4992
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectAttributeCaptureSpecContainer")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FGameplayEffectAttributeCaptureSpecContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012548 RID: 75080 RVA: 0x001AEC0B File Offset: 0x001ACE0B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectAttributeCaptureSpecContainer._ScriptStructPtr != 0) ? FGameplayEffectAttributeCaptureSpecContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectAttributeCaptureSpecContainer", ref FGameplayEffectAttributeCaptureSpecContainer._ScriptStructPtr);
		}

		// Token: 0x17004770 RID: 18288
		// (get) Token: 0x06012549 RID: 75081 RVA: 0x001AEC30 File Offset: 0x001ACE30
		// (set) Token: 0x0601254A RID: 75082 RVA: 0x001AEC73 File Offset: 0x001ACE73
		public TArray<FGameplayEffectAttributeCaptureSpec> SourceAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectAttributeCaptureSpec> result;
				if ((result = this._SourceAttributes) == null)
				{
					result = (this._SourceAttributes = new TArray<FGameplayEffectAttributeCaptureSpec>(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureSpecContainer.__PropertyOffset_SourceAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SourceAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17004771 RID: 18289
		// (get) Token: 0x0601254B RID: 75083 RVA: 0x001AEC84 File Offset: 0x001ACE84
		// (set) Token: 0x0601254C RID: 75084 RVA: 0x001AECC7 File Offset: 0x001ACEC7
		public TArray<FGameplayEffectAttributeCaptureSpec> TargetAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectAttributeCaptureSpec> result;
				if ((result = this._TargetAttributes) == null)
				{
					result = (this._TargetAttributes = new TArray<FGameplayEffectAttributeCaptureSpec>(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureSpecContainer.__PropertyOffset_TargetAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TargetAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17004772 RID: 18290
		// (get) Token: 0x0601254D RID: 75085 RVA: 0x001AECD5 File Offset: 0x001ACED5
		// (set) Token: 0x0601254E RID: 75086 RVA: 0x001AECE5 File Offset: 0x001ACEE5
		public unsafe bool bHasNonSnapshottedAttributes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureSpecContainer.__PropertyOffset_bHasNonSnapshottedAttributes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureSpecContainer.__PropertyOffset_bHasNonSnapshottedAttributes) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601254F RID: 75087 RVA: 0x001AECF6 File Offset: 0x001ACEF6
		public FGameplayEffectAttributeCaptureSpecContainer()
		{
		}

		// Token: 0x06012550 RID: 75088 RVA: 0x001AECFE File Offset: 0x001ACEFE
		public FGameplayEffectAttributeCaptureSpecContainer(TArray<FGameplayEffectAttributeCaptureSpec> SourceAttributes, TArray<FGameplayEffectAttributeCaptureSpec> TargetAttributes, bool bHasNonSnapshottedAttributes)
		{
			this.SourceAttributes = SourceAttributes;
			this.TargetAttributes = TargetAttributes;
			this.bHasNonSnapshottedAttributes = bHasNonSnapshottedAttributes;
		}

		// Token: 0x06012551 RID: 75089 RVA: 0x001AED1B File Offset: 0x001ACF1B
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectAttributeCaptureSpecContainer.StaticStruct();
		}

		// Token: 0x06012552 RID: 75090 RVA: 0x001AED27 File Offset: 0x001ACF27
		[NullableContext(2)]
		public FGameplayEffectAttributeCaptureSpecContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012553 RID: 75091 RVA: 0x001AED31 File Offset: 0x001ACF31
		public FGameplayEffectAttributeCaptureSpecContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012554 RID: 75092 RVA: 0x001AED3C File Offset: 0x001ACF3C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectAttributeCaptureSpecContainer(Pointer, false, true);
		}

		// Token: 0x06012555 RID: 75093 RVA: 0x001AED46 File Offset: 0x001ACF46
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectAttributeCaptureSpecContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04009D06 RID: 40198
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectAttributeCaptureSpecContainer";

		// Token: 0x04009D07 RID: 40199
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D08 RID: 40200
		internal static int __PropertyOffset_SourceAttributes;

		// Token: 0x04009D09 RID: 40201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectAttributeCaptureSpec> _SourceAttributes;

		// Token: 0x04009D0A RID: 40202
		internal static int __PropertyOffset_TargetAttributes;

		// Token: 0x04009D0B RID: 40203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectAttributeCaptureSpec> _TargetAttributes;

		// Token: 0x04009D0C RID: 40204
		internal static int __PropertyOffset_bHasNonSnapshottedAttributes;
	}
}
