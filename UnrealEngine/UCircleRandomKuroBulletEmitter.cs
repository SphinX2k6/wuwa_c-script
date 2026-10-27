using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016D1 RID: 5841
	[UnrealObjectPath("/Script/KuroBulletCore.CircleRandomKuroBulletEmitter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UCircleRandomKuroBulletEmitter : UKuroBulletEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601528F RID: 86671 RVA: 0x001F1A3D File Offset: 0x001EFC3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCircleRandomKuroBulletEmitter._ClassPtr;
		}

		// Token: 0x06015290 RID: 86672 RVA: 0x001F1A4C File Offset: 0x001EFC4C
		public UCircleRandomKuroBulletEmitter() : this(BuiltinUtils.AllocNativeUObject(UCircleRandomKuroBulletEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015291 RID: 86673 RVA: 0x001F1A74 File Offset: 0x001EFC74
		[NullableContext(1)]
		public UCircleRandomKuroBulletEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCircleRandomKuroBulletEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053A1 RID: 21409
		// (get) Token: 0x06015292 RID: 86674 RVA: 0x001F1AA7 File Offset: 0x001EFCA7
		// (set) Token: 0x06015293 RID: 86675 RVA: 0x001F1ABB File Offset: 0x001EFCBB
		[Nullable(2)]
		public unsafe UCircleRandomKuroBulletEmitterConfig CircleConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCircleRandomKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UCircleRandomKuroBulletEmitter.__PropertyOffset_CircleConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCircleRandomKuroBulletEmitter.__PropertyOffset_CircleConfig, value);
			}
		}

		// Token: 0x06015294 RID: 86676 RVA: 0x001F1AD0 File Offset: 0x001EFCD0
		static UCircleRandomKuroBulletEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.CircleRandomKuroBulletEmitter");
		}

		// Token: 0x06015295 RID: 86677 RVA: 0x001F1ADE File Offset: 0x001EFCDE
		protected UCircleRandomKuroBulletEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B82B RID: 47147
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.CircleRandomKuroBulletEmitter";

		// Token: 0x0400B82C RID: 47148
		private static IntPtr _ClassPtr;

		// Token: 0x0400B82D RID: 47149
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B82E RID: 47150
		internal static int __PropertyOffset_CircleConfig;
	}
}
