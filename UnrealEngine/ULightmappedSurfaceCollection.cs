using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D4A RID: 3402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LightmappedSurfaceCollection")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class ULightmappedSurfaceCollection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B7B6 RID: 47030 RVA: 0x00105549 File Offset: 0x00103749
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightmappedSurfaceCollection._ClassPtr;
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x00105558 File Offset: 0x00103758
		public ULightmappedSurfaceCollection() : this(BuiltinUtils.AllocNativeUObject(ULightmappedSurfaceCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x00105580 File Offset: 0x00103780
		public ULightmappedSurfaceCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightmappedSurfaceCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x0600B7B9 RID: 47033 RVA: 0x001055B3 File Offset: 0x001037B3
		// (set) Token: 0x0600B7BA RID: 47034 RVA: 0x001055C7 File Offset: 0x001037C7
		[Nullable(2)]
		public unsafe UModel SourceModel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UModel>(base.NativePtr / (IntPtr)sizeof(void*) + ULightmappedSurfaceCollection.__PropertyOffset_SourceModel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULightmappedSurfaceCollection.__PropertyOffset_SourceModel, value);
			}
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0600B7BB RID: 47035 RVA: 0x001055DC File Offset: 0x001037DC
		// (set) Token: 0x0600B7BC RID: 47036 RVA: 0x00105615 File Offset: 0x00103815
		public TArray<int> Surfaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Surfaces) == null)
				{
					result = (this._Surfaces = new TArray<int>(base.NativePtr + (IntPtr)ULightmappedSurfaceCollection.__PropertyOffset_Surfaces, this));
				}
				return result;
			}
			set
			{
				this.Surfaces.CopyAssign(value);
			}
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x00105623 File Offset: 0x00103823
		static ULightmappedSurfaceCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightmappedSurfaceCollection");
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x00105631 File Offset: 0x00103831
		protected ULightmappedSurfaceCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006038 RID: 24632
		public new const string __ObjectPath = "/Script/Engine.LightmappedSurfaceCollection";

		// Token: 0x04006039 RID: 24633
		private static IntPtr _ClassPtr;

		// Token: 0x0400603A RID: 24634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400603B RID: 24635
		internal static int __PropertyOffset_SourceModel;

		// Token: 0x0400603C RID: 24636
		internal static int __PropertyOffset_Surfaces;

		// Token: 0x0400603D RID: 24637
		[Nullable(2)]
		private TArray<int> _Surfaces;
	}
}
