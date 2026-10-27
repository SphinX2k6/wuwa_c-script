using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D6D RID: 3437
	[UnrealObjectPath("/Script/Engine.MapBuildDataRegistry")]
	[UnrealStructLayout(816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UMapBuildDataRegistry : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B9A2 RID: 47522 RVA: 0x001081DE File Offset: 0x001063DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMapBuildDataRegistry._ClassPtr;
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x001081EC File Offset: 0x001063EC
		public UMapBuildDataRegistry() : this(BuiltinUtils.AllocNativeUObject(UMapBuildDataRegistry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x00108214 File Offset: 0x00106414
		[NullableContext(1)]
		public UMapBuildDataRegistry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMapBuildDataRegistry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x00108247 File Offset: 0x00106447
		// (set) Token: 0x0600B9A6 RID: 47526 RVA: 0x0010825B File Offset: 0x0010645B
		public unsafe TEnumAsByte<ELightingBuildQuality> LevelLightingQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMapBuildDataRegistry.__PropertyOffset_LevelLightingQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMapBuildDataRegistry.__PropertyOffset_LevelLightingQuality) = value;
			}
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x00108270 File Offset: 0x00106470
		static UMapBuildDataRegistry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MapBuildDataRegistry");
		}

		// Token: 0x0600B9A8 RID: 47528 RVA: 0x0010827E File Offset: 0x0010647E
		protected UMapBuildDataRegistry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006143 RID: 24899
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MapBuildDataRegistry";

		// Token: 0x04006144 RID: 24900
		private static IntPtr _ClassPtr;

		// Token: 0x04006145 RID: 24901
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006146 RID: 24902
		internal static int __PropertyOffset_LevelLightingQuality;
	}
}
