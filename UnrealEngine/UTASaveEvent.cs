using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028FD RID: 10493
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.TASaveEvent")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UTASaveEvent : USaveGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026E96 RID: 159382 RVA: 0x003B5C07 File Offset: 0x003B3E07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTASaveEvent._ClassPtr;
		}

		// Token: 0x06026E97 RID: 159383 RVA: 0x003B5C14 File Offset: 0x003B3E14
		public UTASaveEvent() : this(BuiltinUtils.AllocNativeUObject(UTASaveEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026E98 RID: 159384 RVA: 0x003B5C3C File Offset: 0x003B3E3C
		public UTASaveEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTASaveEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095EA RID: 38378
		// (get) Token: 0x06026E99 RID: 159385 RVA: 0x003B5C70 File Offset: 0x003B3E70
		// (set) Token: 0x06026E9A RID: 159386 RVA: 0x003B5CA9 File Offset: 0x003B3EA9
		public TArray<string> EventJsons
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EventJsons) == null)
				{
					result = (this._EventJsons = new TArray<string>(base.NativePtr + (IntPtr)UTASaveEvent.__PropertyOffset_EventJsons, this));
				}
				return result;
			}
			set
			{
				this.EventJsons.CopyAssign(value);
			}
		}

		// Token: 0x170095EB RID: 38379
		// (get) Token: 0x06026E9B RID: 159387 RVA: 0x003B5CB7 File Offset: 0x003B3EB7
		// (set) Token: 0x06026E9C RID: 159388 RVA: 0x003B5CC7 File Offset: 0x003B3EC7
		public unsafe uint UserIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTASaveEvent.__PropertyOffset_UserIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTASaveEvent.__PropertyOffset_UserIndex) = (int)value;
			}
		}

		// Token: 0x06026E9D RID: 159389 RVA: 0x003B5CD8 File Offset: 0x003B3ED8
		static UTASaveEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TASdkPlugin.TASaveEvent");
		}

		// Token: 0x06026E9E RID: 159390 RVA: 0x003B5CE6 File Offset: 0x003B3EE6
		protected UTASaveEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155D7 RID: 87511
		public new const string __ObjectPath = "/Script/TASdkPlugin.TASaveEvent";

		// Token: 0x040155D8 RID: 87512
		private static IntPtr _ClassPtr;

		// Token: 0x040155D9 RID: 87513
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040155DA RID: 87514
		internal static int __PropertyOffset_EventJsons;

		// Token: 0x040155DB RID: 87515
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EventJsons;

		// Token: 0x040155DC RID: 87516
		internal static int __PropertyOffset_UserIndex;
	}
}
