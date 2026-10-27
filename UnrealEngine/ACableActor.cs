using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000436 RID: 1078
	[UnrealObjectPath("/Script/CableComponent.CableActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ACableActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060039F9 RID: 14841 RVA: 0x00057DCE File Offset: 0x00055FCE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACableActor._ClassPtr;
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00057DDC File Offset: 0x00055FDC
		public ACableActor() : this(BuiltinUtils.AllocNativeUObject(ACableActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x00057E04 File Offset: 0x00056004
		[NullableContext(1)]
		public ACableActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACableActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x00057E37 File Offset: 0x00056037
		// (set) Token: 0x060039FD RID: 14845 RVA: 0x00057E4B File Offset: 0x0005604B
		[Nullable(2)]
		public unsafe UCableComponent CableComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCableComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACableActor.__PropertyOffset_CableComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACableActor.__PropertyOffset_CableComponent, value);
			}
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x00057E60 File Offset: 0x00056060
		static ACableActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CableComponent.CableActor");
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x00057E6E File Offset: 0x0005606E
		protected ACableActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001A6C RID: 6764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CableComponent.CableActor";

		// Token: 0x04001A6D RID: 6765
		private static IntPtr _ClassPtr;

		// Token: 0x04001A6E RID: 6766
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001A6F RID: 6767
		internal static int __PropertyOffset_CableComponent;
	}
}
