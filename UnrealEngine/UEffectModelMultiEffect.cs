using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C8 RID: 968
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelMultiEffect")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UEffectModelMultiEffect : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005E96 RID: 24214 RVA: 0x00085DFC File Offset: 0x00083FFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelMultiEffect._ClassPtr;
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x00085E08 File Offset: 0x00084008
		public UEffectModelMultiEffect() : this(BuiltinUtils.AllocNativeUObject(UEffectModelMultiEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x00085E30 File Offset: 0x00084030
		[NullableContext(1)]
		public UEffectModelMultiEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x00085E63 File Offset: 0x00084063
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x00085E77 File Offset: 0x00084077
		[Nullable(2)]
		public unsafe UEffectModelBase EffectData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMultiEffect.__PropertyOffset_EffectData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMultiEffect.__PropertyOffset_EffectData, value);
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x00085E8C File Offset: 0x0008408C
		// (set) Token: 0x06005E9C RID: 24220 RVA: 0x00085E9C File Offset: 0x0008409C
		public unsafe int BaseNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_BaseNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_BaseNum) = value;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06005E9D RID: 24221 RVA: 0x00085EAD File Offset: 0x000840AD
		// (set) Token: 0x06005E9E RID: 24222 RVA: 0x00085EBD File Offset: 0x000840BD
		public unsafe float SpinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_SpinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_SpinSpeed) = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06005E9F RID: 24223 RVA: 0x00085ECE File Offset: 0x000840CE
		// (set) Token: 0x06005EA0 RID: 24224 RVA: 0x00085EDE File Offset: 0x000840DE
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x00085EEF File Offset: 0x000840EF
		static UEffectModelMultiEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelMultiEffect");
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x00085EFD File Offset: 0x000840FD
		protected UEffectModelMultiEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400279C RID: 10140
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelMultiEffect";

		// Token: 0x0400279D RID: 10141
		private static IntPtr _ClassPtr;

		// Token: 0x0400279E RID: 10142
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400279F RID: 10143
		internal static int __PropertyOffset_EffectData;

		// Token: 0x040027A0 RID: 10144
		internal static int __PropertyOffset_BaseNum;

		// Token: 0x040027A1 RID: 10145
		internal static int __PropertyOffset_SpinSpeed;

		// Token: 0x040027A2 RID: 10146
		internal static int __PropertyOffset_Radius;
	}
}
