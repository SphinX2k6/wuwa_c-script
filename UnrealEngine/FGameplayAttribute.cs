using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001368 RID: 4968
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAttribute")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FGameplayAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012383 RID: 74627 RVA: 0x001ABF02 File Offset: 0x001AA102
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAttribute._ScriptStructPtr != 0) ? FGameplayAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAttribute", ref FGameplayAttribute._ScriptStructPtr);
		}

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x06012384 RID: 74628 RVA: 0x001ABF26 File Offset: 0x001AA126
		// (set) Token: 0x06012385 RID: 74629 RVA: 0x001ABF3A File Offset: 0x001AA13A
		public unsafe string AttributeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayAttribute.__PropertyOffset_AttributeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayAttribute.__PropertyOffset_AttributeName)), value);
			}
		}

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x06012386 RID: 74630 RVA: 0x001ABF4F File Offset: 0x001AA14F
		// (set) Token: 0x06012387 RID: 74631 RVA: 0x001ABF5F File Offset: 0x001AA15F
		public unsafe Unusable Attribute
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAttribute.__PropertyOffset_Attribute);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAttribute.__PropertyOffset_Attribute) = value;
			}
		}

		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x06012388 RID: 74632 RVA: 0x001ABF70 File Offset: 0x001AA170
		// (set) Token: 0x06012389 RID: 74633 RVA: 0x001ABF84 File Offset: 0x001AA184
		[Nullable(2)]
		public unsafe UStruct AttributeOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStruct>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAttribute.__PropertyOffset_AttributeOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAttribute.__PropertyOffset_AttributeOwner, value);
			}
		}

		// Token: 0x0601238A RID: 74634 RVA: 0x001ABF99 File Offset: 0x001AA199
		public FGameplayAttribute()
		{
		}

		// Token: 0x0601238B RID: 74635 RVA: 0x001ABFA1 File Offset: 0x001AA1A1
		public FGameplayAttribute(string AttributeName, Unusable Attribute, UStruct AttributeOwner)
		{
			this.AttributeName = AttributeName;
			this.Attribute = Attribute;
			this.AttributeOwner = AttributeOwner;
		}

		// Token: 0x0601238C RID: 74636 RVA: 0x001ABFBE File Offset: 0x001AA1BE
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAttribute.StaticStruct();
		}

		// Token: 0x0601238D RID: 74637 RVA: 0x001ABFCA File Offset: 0x001AA1CA
		[NullableContext(2)]
		public FGameplayAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601238E RID: 74638 RVA: 0x001ABFD4 File Offset: 0x001AA1D4
		public FGameplayAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601238F RID: 74639 RVA: 0x001ABFDF File Offset: 0x001AA1DF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAttribute(Pointer, false, true);
		}

		// Token: 0x06012390 RID: 74640 RVA: 0x001ABFE9 File Offset: 0x001AA1E9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04009C21 RID: 39969
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAttribute";

		// Token: 0x04009C22 RID: 39970
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C23 RID: 39971
		internal static int __PropertyOffset_AttributeName;

		// Token: 0x04009C24 RID: 39972
		internal static int __PropertyOffset_Attribute;

		// Token: 0x04009C25 RID: 39973
		internal static int __PropertyOffset_AttributeOwner;
	}
}
