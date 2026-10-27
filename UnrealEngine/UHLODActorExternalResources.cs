using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C26 RID: 3110
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODActorExternalResources")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UHLODActorExternalResources : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009DDF RID: 40415 RVA: 0x000E06A8 File Offset: 0x000DE8A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODActorExternalResources._ClassPtr;
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x000E06B4 File Offset: 0x000DE8B4
		public UHLODActorExternalResources() : this(BuiltinUtils.AllocNativeUObject(UHLODActorExternalResources.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x000E06DC File Offset: 0x000DE8DC
		public UHLODActorExternalResources(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODActorExternalResources.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x000E0710 File Offset: 0x000DE910
		// (set) Token: 0x06009DE3 RID: 40419 RVA: 0x000E0749 File Offset: 0x000DE949
		public TArray<UObject> Resources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Resources) == null)
				{
					result = (this._Resources = new TArray<UObject>(base.NativePtr + (IntPtr)UHLODActorExternalResources.__PropertyOffset_Resources, this));
				}
				return result;
			}
			set
			{
				this.Resources.CopyAssign(value);
			}
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x000E0757 File Offset: 0x000DE957
		static UHLODActorExternalResources()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODActorExternalResources");
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x000E0765 File Offset: 0x000DE965
		protected UHLODActorExternalResources(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400570E RID: 22286
		public new const string __ObjectPath = "/Script/Engine.HLODActorExternalResources";

		// Token: 0x0400570F RID: 22287
		private static IntPtr _ClassPtr;

		// Token: 0x04005710 RID: 22288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005711 RID: 22289
		internal static int __PropertyOffset_Resources;

		// Token: 0x04005712 RID: 22290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Resources;
	}
}
