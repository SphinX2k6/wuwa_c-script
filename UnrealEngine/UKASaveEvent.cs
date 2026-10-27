using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015E2 RID: 5602
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KASaveEvent")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKASaveEvent : USaveGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014334 RID: 82740 RVA: 0x001DABBF File Offset: 0x001D8DBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKASaveEvent._ClassPtr;
		}

		// Token: 0x06014335 RID: 82741 RVA: 0x001DABCC File Offset: 0x001D8DCC
		public UKASaveEvent() : this(BuiltinUtils.AllocNativeUObject(UKASaveEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014336 RID: 82742 RVA: 0x001DABF4 File Offset: 0x001D8DF4
		public UKASaveEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKASaveEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x06014337 RID: 82743 RVA: 0x001DAC28 File Offset: 0x001D8E28
		// (set) Token: 0x06014338 RID: 82744 RVA: 0x001DAC61 File Offset: 0x001D8E61
		public TArray<string> EventJsons
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EventJsons) == null)
				{
					result = (this._EventJsons = new TArray<string>(base.NativePtr + (IntPtr)UKASaveEvent.__PropertyOffset_EventJsons, this));
				}
				return result;
			}
			set
			{
				this.EventJsons.CopyAssign(value);
			}
		}

		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x06014339 RID: 82745 RVA: 0x001DAC6F File Offset: 0x001D8E6F
		// (set) Token: 0x0601433A RID: 82746 RVA: 0x001DAC7F File Offset: 0x001D8E7F
		public unsafe uint UserIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKASaveEvent.__PropertyOffset_UserIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKASaveEvent.__PropertyOffset_UserIndex) = (int)value;
			}
		}

		// Token: 0x0601433B RID: 82747 RVA: 0x001DAC90 File Offset: 0x001D8E90
		static UKASaveEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KASaveEvent");
		}

		// Token: 0x0601433C RID: 82748 RVA: 0x001DAC9E File Offset: 0x001D8E9E
		protected UKASaveEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AFCA RID: 45002
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KASaveEvent";

		// Token: 0x0400AFCB RID: 45003
		private static IntPtr _ClassPtr;

		// Token: 0x0400AFCC RID: 45004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AFCD RID: 45005
		internal static int __PropertyOffset_EventJsons;

		// Token: 0x0400AFCE RID: 45006
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EventJsons;

		// Token: 0x0400AFCF RID: 45007
		internal static int __PropertyOffset_UserIndex;
	}
}
