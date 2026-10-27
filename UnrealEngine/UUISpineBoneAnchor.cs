using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B5 RID: 8629
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpineBoneAnchor")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UUISpineBoneAnchor : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D30 RID: 134448 RVA: 0x00307FF3 File Offset: 0x003061F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpineBoneAnchor._ClassPtr;
		}

		// Token: 0x06020D31 RID: 134449 RVA: 0x00308000 File Offset: 0x00306200
		public UUISpineBoneAnchor() : this(BuiltinUtils.AllocNativeUObject(UUISpineBoneAnchor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D32 RID: 134450 RVA: 0x00308028 File Offset: 0x00306228
		[NullableContext(1)]
		public UUISpineBoneAnchor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpineBoneAnchor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008034 RID: 32820
		// (get) Token: 0x06020D33 RID: 134451 RVA: 0x0030805C File Offset: 0x0030625C
		// (set) Token: 0x06020D34 RID: 134452 RVA: 0x00308095 File Offset: 0x00306295
		[Nullable(1)]
		public TArray<FAnchorInfo> AnchorInfos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FAnchorInfo> result;
				if ((result = this._AnchorInfos) == null)
				{
					result = (this._AnchorInfos = new TArray<FAnchorInfo>(base.NativePtr + (IntPtr)UUISpineBoneAnchor.__PropertyOffset_AnchorInfos, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnchorInfos.CopyAssign(value);
			}
		}

		// Token: 0x17008035 RID: 32821
		// (get) Token: 0x06020D35 RID: 134453 RVA: 0x003080A3 File Offset: 0x003062A3
		// (set) Token: 0x06020D36 RID: 134454 RVA: 0x003080B7 File Offset: 0x003062B7
		public unsafe USpineSkeletonComponent SpineSkeletonComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineBoneAnchor.__PropertyOffset_SpineSkeletonComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineBoneAnchor.__PropertyOffset_SpineSkeletonComponent, value);
			}
		}

		// Token: 0x17008036 RID: 32822
		// (get) Token: 0x06020D37 RID: 134455 RVA: 0x003080CC File Offset: 0x003062CC
		// (set) Token: 0x06020D38 RID: 134456 RVA: 0x003080E0 File Offset: 0x003062E0
		public unsafe USpineSkeletonDataAsset CurrSkeletonData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineBoneAnchor.__PropertyOffset_CurrSkeletonData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineBoneAnchor.__PropertyOffset_CurrSkeletonData, value);
			}
		}

		// Token: 0x06020D39 RID: 134457 RVA: 0x003080F5 File Offset: 0x003062F5
		static UUISpineBoneAnchor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpineBoneAnchor");
		}

		// Token: 0x06020D3A RID: 134458 RVA: 0x00308103 File Offset: 0x00306303
		protected UUISpineBoneAnchor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011887 RID: 71815
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpineBoneAnchor";

		// Token: 0x04011888 RID: 71816
		private static IntPtr _ClassPtr;

		// Token: 0x04011889 RID: 71817
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401188A RID: 71818
		internal static int __PropertyOffset_AnchorInfos;

		// Token: 0x0401188B RID: 71819
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnchorInfo> _AnchorInfos;

		// Token: 0x0401188C RID: 71820
		internal static int __PropertyOffset_SpineSkeletonComponent;

		// Token: 0x0401188D RID: 71821
		internal static int __PropertyOffset_CurrSkeletonData;
	}
}
