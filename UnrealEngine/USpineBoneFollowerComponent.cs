using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028AE RID: 10414
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineBoneFollowerComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class USpineBoneFollowerComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060269C4 RID: 158148 RVA: 0x003AEBDD File Offset: 0x003ACDDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineBoneFollowerComponent._ClassPtr;
		}

		// Token: 0x060269C5 RID: 158149 RVA: 0x003AEBEC File Offset: 0x003ACDEC
		public USpineBoneFollowerComponent() : this(BuiltinUtils.AllocNativeUObject(USpineBoneFollowerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060269C6 RID: 158150 RVA: 0x003AEC14 File Offset: 0x003ACE14
		public USpineBoneFollowerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineBoneFollowerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094D5 RID: 38101
		// (get) Token: 0x060269C7 RID: 158151 RVA: 0x003AEC47 File Offset: 0x003ACE47
		// (set) Token: 0x060269C8 RID: 158152 RVA: 0x003AEC5B File Offset: 0x003ACE5B
		[Nullable(2)]
		public unsafe AActor Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + USpineBoneFollowerComponent.__PropertyOffset_Target);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineBoneFollowerComponent.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x170094D6 RID: 38102
		// (get) Token: 0x060269C9 RID: 158153 RVA: 0x003AEC70 File Offset: 0x003ACE70
		// (set) Token: 0x060269CA RID: 158154 RVA: 0x003AEC84 File Offset: 0x003ACE84
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USpineBoneFollowerComponent.__PropertyOffset_BoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USpineBoneFollowerComponent.__PropertyOffset_BoneName)), value);
			}
		}

		// Token: 0x170094D7 RID: 38103
		// (get) Token: 0x060269CB RID: 158155 RVA: 0x003AEC99 File Offset: 0x003ACE99
		// (set) Token: 0x060269CC RID: 158156 RVA: 0x003AECA9 File Offset: 0x003ACEA9
		public unsafe bool UseComponentTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UseComponentTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UseComponentTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x170094D8 RID: 38104
		// (get) Token: 0x060269CD RID: 158157 RVA: 0x003AECBA File Offset: 0x003ACEBA
		// (set) Token: 0x060269CE RID: 158158 RVA: 0x003AECCA File Offset: 0x003ACECA
		public unsafe bool UsePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UsePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UsePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170094D9 RID: 38105
		// (get) Token: 0x060269CF RID: 158159 RVA: 0x003AECDB File Offset: 0x003ACEDB
		// (set) Token: 0x060269D0 RID: 158160 RVA: 0x003AECEB File Offset: 0x003ACEEB
		public unsafe bool UseRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UseRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UseRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170094DA RID: 38106
		// (get) Token: 0x060269D1 RID: 158161 RVA: 0x003AECFC File Offset: 0x003ACEFC
		// (set) Token: 0x060269D2 RID: 158162 RVA: 0x003AED0C File Offset: 0x003ACF0C
		public unsafe bool UseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UseScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneFollowerComponent.__PropertyOffset_UseScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x060269D3 RID: 158163 RVA: 0x003AED1D File Offset: 0x003ACF1D
		static USpineBoneFollowerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineBoneFollowerComponent");
		}

		// Token: 0x060269D4 RID: 158164 RVA: 0x003AED2B File Offset: 0x003ACF2B
		protected USpineBoneFollowerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401534B RID: 86859
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineBoneFollowerComponent";

		// Token: 0x0401534C RID: 86860
		private static IntPtr _ClassPtr;

		// Token: 0x0401534D RID: 86861
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401534E RID: 86862
		internal static int __PropertyOffset_Target;

		// Token: 0x0401534F RID: 86863
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04015350 RID: 86864
		internal static int __PropertyOffset_UseComponentTransform;

		// Token: 0x04015351 RID: 86865
		internal static int __PropertyOffset_UsePosition;

		// Token: 0x04015352 RID: 86866
		internal static int __PropertyOffset_UseRotation;

		// Token: 0x04015353 RID: 86867
		internal static int __PropertyOffset_UseScale;
	}
}
