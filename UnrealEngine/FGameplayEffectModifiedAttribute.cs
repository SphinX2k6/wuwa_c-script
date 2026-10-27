using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200138C RID: 5004
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectModifiedAttribute")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FGameplayEffectModifiedAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060125EA RID: 75242 RVA: 0x001AFCEC File Offset: 0x001ADEEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectModifiedAttribute._ScriptStructPtr != 0) ? FGameplayEffectModifiedAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectModifiedAttribute", ref FGameplayEffectModifiedAttribute._ScriptStructPtr);
		}

		// Token: 0x17004795 RID: 18325
		// (get) Token: 0x060125EB RID: 75243 RVA: 0x001AFD10 File Offset: 0x001ADF10
		// (set) Token: 0x060125EC RID: 75244 RVA: 0x001AFD53 File Offset: 0x001ADF53
		public FGameplayAttribute Attribute
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttribute result;
				if ((result = this._Attribute) == null)
				{
					result = (this._Attribute = new FGameplayAttribute(base.NativePtr + (IntPtr)FGameplayEffectModifiedAttribute.__PropertyOffset_Attribute, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttribute.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectModifiedAttribute.__PropertyOffset_Attribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004796 RID: 18326
		// (get) Token: 0x060125ED RID: 75245 RVA: 0x001AFD74 File Offset: 0x001ADF74
		// (set) Token: 0x060125EE RID: 75246 RVA: 0x001AFD84 File Offset: 0x001ADF84
		public unsafe float TotalMagnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectModifiedAttribute.__PropertyOffset_TotalMagnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectModifiedAttribute.__PropertyOffset_TotalMagnitude) = value;
			}
		}

		// Token: 0x060125EF RID: 75247 RVA: 0x001AFD95 File Offset: 0x001ADF95
		public FGameplayEffectModifiedAttribute()
		{
		}

		// Token: 0x060125F0 RID: 75248 RVA: 0x001AFD9D File Offset: 0x001ADF9D
		public FGameplayEffectModifiedAttribute(FGameplayAttribute Attribute, float TotalMagnitude)
		{
			this.Attribute = Attribute;
			this.TotalMagnitude = TotalMagnitude;
		}

		// Token: 0x060125F1 RID: 75249 RVA: 0x001AFDB3 File Offset: 0x001ADFB3
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectModifiedAttribute.StaticStruct();
		}

		// Token: 0x060125F2 RID: 75250 RVA: 0x001AFDBF File Offset: 0x001ADFBF
		[NullableContext(2)]
		public FGameplayEffectModifiedAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060125F3 RID: 75251 RVA: 0x001AFDC9 File Offset: 0x001ADFC9
		public FGameplayEffectModifiedAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060125F4 RID: 75252 RVA: 0x001AFDD4 File Offset: 0x001ADFD4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectModifiedAttribute(Pointer, false, true);
		}

		// Token: 0x060125F5 RID: 75253 RVA: 0x001AFDDE File Offset: 0x001ADFDE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectModifiedAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04009D5C RID: 40284
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectModifiedAttribute";

		// Token: 0x04009D5D RID: 40285
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D5E RID: 40286
		internal static int __PropertyOffset_Attribute;

		// Token: 0x04009D5F RID: 40287
		[Nullable(2)]
		private FGameplayAttribute _Attribute;

		// Token: 0x04009D60 RID: 40288
		internal static int __PropertyOffset_TotalMagnitude;
	}
}
