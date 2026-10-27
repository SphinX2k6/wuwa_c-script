using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200262B RID: 9771
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Overlay.BasicOverlays")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UBasicOverlays : UOverlays, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024588 RID: 148872 RVA: 0x0035CFAD File Offset: 0x0035B1AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBasicOverlays._ClassPtr;
		}

		// Token: 0x06024589 RID: 148873 RVA: 0x0035CFBC File Offset: 0x0035B1BC
		public UBasicOverlays() : this(BuiltinUtils.AllocNativeUObject(UBasicOverlays.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602458A RID: 148874 RVA: 0x0035CFE4 File Offset: 0x0035B1E4
		public UBasicOverlays(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBasicOverlays.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C0D RID: 35853
		// (get) Token: 0x0602458B RID: 148875 RVA: 0x0035D018 File Offset: 0x0035B218
		// (set) Token: 0x0602458C RID: 148876 RVA: 0x0035D051 File Offset: 0x0035B251
		public TArray<FOverlayItem> Overlays
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOverlayItem> result;
				if ((result = this._Overlays) == null)
				{
					result = (this._Overlays = new TArray<FOverlayItem>(base.NativePtr + (IntPtr)UBasicOverlays.__PropertyOffset_Overlays, this));
				}
				return result;
			}
			set
			{
				this.Overlays.CopyAssign(value);
			}
		}

		// Token: 0x0602458D RID: 148877 RVA: 0x0035D05F File Offset: 0x0035B25F
		static UBasicOverlays()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Overlay.BasicOverlays");
		}

		// Token: 0x0602458E RID: 148878 RVA: 0x0035D06D File Offset: 0x0035B26D
		protected UBasicOverlays(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040137FE RID: 79870
		public new const string __ObjectPath = "/Script/Overlay.BasicOverlays";

		// Token: 0x040137FF RID: 79871
		private static IntPtr _ClassPtr;

		// Token: 0x04013800 RID: 79872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013801 RID: 79873
		internal static int __PropertyOffset_Overlays;

		// Token: 0x04013802 RID: 79874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOverlayItem> _Overlays;
	}
}
