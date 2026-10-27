using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200262C RID: 9772
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Overlay.LocalizedOverlays")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class ULocalizedOverlays : UOverlays, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602458F RID: 148879 RVA: 0x0035D076 File Offset: 0x0035B276
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalizedOverlays._ClassPtr;
		}

		// Token: 0x06024590 RID: 148880 RVA: 0x0035D084 File Offset: 0x0035B284
		public ULocalizedOverlays() : this(BuiltinUtils.AllocNativeUObject(ULocalizedOverlays.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024591 RID: 148881 RVA: 0x0035D0AC File Offset: 0x0035B2AC
		public ULocalizedOverlays(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULocalizedOverlays.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C0E RID: 35854
		// (get) Token: 0x06024592 RID: 148882 RVA: 0x0035D0DF File Offset: 0x0035B2DF
		// (set) Token: 0x06024593 RID: 148883 RVA: 0x0035D0F3 File Offset: 0x0035B2F3
		[Nullable(2)]
		public unsafe UBasicOverlays DefaultOverlays
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBasicOverlays>(base.NativePtr / (IntPtr)sizeof(void*) + ULocalizedOverlays.__PropertyOffset_DefaultOverlays);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULocalizedOverlays.__PropertyOffset_DefaultOverlays, value);
			}
		}

		// Token: 0x17008C0F RID: 35855
		// (get) Token: 0x06024594 RID: 148884 RVA: 0x0035D108 File Offset: 0x0035B308
		// (set) Token: 0x06024595 RID: 148885 RVA: 0x0035D141 File Offset: 0x0035B341
		public TMap<string, UBasicOverlays> LocaleToOverlaysMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UBasicOverlays> result;
				if ((result = this._LocaleToOverlaysMap) == null)
				{
					result = (this._LocaleToOverlaysMap = new TMap<string, UBasicOverlays>(base.NativePtr + (IntPtr)ULocalizedOverlays.__PropertyOffset_LocaleToOverlaysMap, this));
				}
				return result;
			}
			set
			{
				this.LocaleToOverlaysMap.CopyAssign(value);
			}
		}

		// Token: 0x06024596 RID: 148886 RVA: 0x0035D14F File Offset: 0x0035B34F
		static ULocalizedOverlays()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Overlay.LocalizedOverlays");
		}

		// Token: 0x06024597 RID: 148887 RVA: 0x0035D15D File Offset: 0x0035B35D
		protected ULocalizedOverlays(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013803 RID: 79875
		public new const string __ObjectPath = "/Script/Overlay.LocalizedOverlays";

		// Token: 0x04013804 RID: 79876
		private static IntPtr _ClassPtr;

		// Token: 0x04013805 RID: 79877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013806 RID: 79878
		internal static int __PropertyOffset_DefaultOverlays;

		// Token: 0x04013807 RID: 79879
		internal static int __PropertyOffset_LocaleToOverlaysMap;

		// Token: 0x04013808 RID: 79880
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UBasicOverlays> _LocaleToOverlaysMap;
	}
}
