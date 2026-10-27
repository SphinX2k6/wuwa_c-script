using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009B4 RID: 2484
	[UnrealObjectPath("/Script/Engine.DeprecatedDataLayerInstance")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UDeprecatedDataLayerInstance : UDataLayerInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C6B RID: 35947 RVA: 0x000C8FCA File Offset: 0x000C71CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDeprecatedDataLayerInstance._ClassPtr;
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x000C8FD8 File Offset: 0x000C71D8
		public UDeprecatedDataLayerInstance() : this(BuiltinUtils.AllocNativeUObject(UDeprecatedDataLayerInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x000C9000 File Offset: 0x000C7200
		[NullableContext(1)]
		public UDeprecatedDataLayerInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDeprecatedDataLayerInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06008C6E RID: 35950 RVA: 0x000C9033 File Offset: 0x000C7233
		// (set) Token: 0x06008C6F RID: 35951 RVA: 0x000C9047 File Offset: 0x000C7247
		public unsafe FName Label
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_Label);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_Label) = value;
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06008C70 RID: 35952 RVA: 0x000C905C File Offset: 0x000C725C
		// (set) Token: 0x06008C71 RID: 35953 RVA: 0x000C9070 File Offset: 0x000C7270
		public unsafe FName DeprecatedDataLayerFName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_DeprecatedDataLayerFName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_DeprecatedDataLayerFName) = value;
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06008C72 RID: 35954 RVA: 0x000C9085 File Offset: 0x000C7285
		// (set) Token: 0x06008C73 RID: 35955 RVA: 0x000C9099 File Offset: 0x000C7299
		[Nullable(2)]
		public unsafe UDataLayer CachedDeprecatedDataLayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataLayer>(base.NativePtr / (IntPtr)sizeof(void*) + UDeprecatedDataLayerInstance.__PropertyOffset_CachedDeprecatedDataLayer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDeprecatedDataLayerInstance.__PropertyOffset_CachedDeprecatedDataLayer, value);
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06008C74 RID: 35956 RVA: 0x000C90AE File Offset: 0x000C72AE
		// (set) Token: 0x06008C75 RID: 35957 RVA: 0x000C90BE File Offset: 0x000C72BE
		public unsafe EDataLayerType DataLayerType
		{
			get
			{
				return (EDataLayerType)(*(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_DataLayerType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_DataLayerType) = (byte)value;
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06008C76 RID: 35958 RVA: 0x000C90CF File Offset: 0x000C72CF
		// (set) Token: 0x06008C77 RID: 35959 RVA: 0x000C90E3 File Offset: 0x000C72E3
		public unsafe FColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDeprecatedDataLayerInstance.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x06008C78 RID: 35960 RVA: 0x000C90F8 File Offset: 0x000C72F8
		static UDeprecatedDataLayerInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DeprecatedDataLayerInstance");
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x000C9106 File Offset: 0x000C7306
		protected UDeprecatedDataLayerInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042AA RID: 17066
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DeprecatedDataLayerInstance";

		// Token: 0x040042AB RID: 17067
		private static IntPtr _ClassPtr;

		// Token: 0x040042AC RID: 17068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042AD RID: 17069
		internal static int __PropertyOffset_Label;

		// Token: 0x040042AE RID: 17070
		internal static int __PropertyOffset_DeprecatedDataLayerFName;

		// Token: 0x040042AF RID: 17071
		internal static int __PropertyOffset_CachedDeprecatedDataLayer;

		// Token: 0x040042B0 RID: 17072
		internal static int __PropertyOffset_DataLayerType;

		// Token: 0x040042B1 RID: 17073
		internal static int __PropertyOffset_DebugColor;
	}
}
