using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001115 RID: 4373
	[UnrealObjectPath("/Script/Engine.SkyLight")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ASkyLight : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FEB8 RID: 65208 RVA: 0x00177BE2 File Offset: 0x00175DE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASkyLight._ClassPtr;
		}

		// Token: 0x0600FEB9 RID: 65209 RVA: 0x00177BF0 File Offset: 0x00175DF0
		public ASkyLight() : this(BuiltinUtils.AllocNativeUObject(ASkyLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FEBA RID: 65210 RVA: 0x00177C18 File Offset: 0x00175E18
		[NullableContext(1)]
		public ASkyLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASkyLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0600FEBB RID: 65211 RVA: 0x00177C4B File Offset: 0x00175E4B
		// (set) Token: 0x0600FEBC RID: 65212 RVA: 0x00177C5F File Offset: 0x00175E5F
		[Nullable(2)]
		public unsafe USkyLightComponent LightComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASkyLight.__PropertyOffset_LightComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkyLight.__PropertyOffset_LightComponent, value);
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0600FEBD RID: 65213 RVA: 0x00177C74 File Offset: 0x00175E74
		// (set) Token: 0x0600FEBE RID: 65214 RVA: 0x00177C8D File Offset: 0x00175E8D
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ASkyLight.__PropertyOffset_bEnabled) & ASkyLight.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ASkyLight.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)ASkyLight.__PropertyOffset_bEnabled) & ~ASkyLight.__PropertyMask_bEnabled) | (value ? ASkyLight.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x0600FEBF RID: 65215 RVA: 0x00177CBD File Offset: 0x00175EBD
		public void OnRep_bEnabled()
		{
			ASkyLight.__OnRep_bEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600FEC0 RID: 65216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_bEnabled_Internal(IntPtr @this);

		// Token: 0x0600FEC1 RID: 65217 RVA: 0x00177CCA File Offset: 0x00175ECA
		static ASkyLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkyLight");
		}

		// Token: 0x0600FEC2 RID: 65218 RVA: 0x00177CD8 File Offset: 0x00175ED8
		protected ASkyLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008921 RID: 35105
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkyLight";

		// Token: 0x04008922 RID: 35106
		private static IntPtr _ClassPtr;

		// Token: 0x04008923 RID: 35107
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008924 RID: 35108
		internal static int __PropertyOffset_LightComponent;

		// Token: 0x04008925 RID: 35109
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04008926 RID: 35110
		internal static byte __PropertyMask_bEnabled;
	}
}
