using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015E3 RID: 5603
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KASaveEventV2")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKASaveEventV2 : USaveGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601433D RID: 82749 RVA: 0x001DACA7 File Offset: 0x001D8EA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKASaveEventV2._ClassPtr;
		}

		// Token: 0x0601433E RID: 82750 RVA: 0x001DACB4 File Offset: 0x001D8EB4
		public UKASaveEventV2() : this(BuiltinUtils.AllocNativeUObject(UKASaveEventV2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601433F RID: 82751 RVA: 0x001DACDC File Offset: 0x001D8EDC
		public UKASaveEventV2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKASaveEventV2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x06014340 RID: 82752 RVA: 0x001DAD10 File Offset: 0x001D8F10
		// (set) Token: 0x06014341 RID: 82753 RVA: 0x001DAD49 File Offset: 0x001D8F49
		public TArray<FKASingleEvent> EventsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKASingleEvent> result;
				if ((result = this._EventsArray) == null)
				{
					result = (this._EventsArray = new TArray<FKASingleEvent>(base.NativePtr + (IntPtr)UKASaveEventV2.__PropertyOffset_EventsArray, this));
				}
				return result;
			}
			set
			{
				this.EventsArray.CopyAssign(value);
			}
		}

		// Token: 0x06014342 RID: 82754 RVA: 0x001DAD57 File Offset: 0x001D8F57
		static UKASaveEventV2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KASaveEventV2");
		}

		// Token: 0x06014343 RID: 82755 RVA: 0x001DAD65 File Offset: 0x001D8F65
		protected UKASaveEventV2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AFD0 RID: 45008
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KASaveEventV2";

		// Token: 0x0400AFD1 RID: 45009
		private static IntPtr _ClassPtr;

		// Token: 0x0400AFD2 RID: 45010
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AFD3 RID: 45011
		internal static int __PropertyOffset_EventsArray;

		// Token: 0x0400AFD4 RID: 45012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKASingleEvent> _EventsArray;
	}
}
