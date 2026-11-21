using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C0 RID: 192
	[UnrealObjectPath("/Script/AkAudio.AkEventCallbackInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAkEventCallbackInfo : UAkCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x00016403 File Offset: 0x00014603
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkEventCallbackInfo._ClassPtr;
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00016410 File Offset: 0x00014610
		public UAkEventCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkEventCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00016438 File Offset: 0x00014638
		[NullableContext(1)]
		public UAkEventCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkEventCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0001646B File Offset: 0x0001466B
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0001647B File Offset: 0x0001467B
		public unsafe int PlayingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_PlayingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_PlayingID) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0001648C File Offset: 0x0001468C
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0001649C File Offset: 0x0001469C
		public unsafe int EventID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_EventID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkEventCallbackInfo.__PropertyOffset_EventID) = value;
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000164AD File Offset: 0x000146AD
		static UAkEventCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkEventCallbackInfo");
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000164BB File Offset: 0x000146BB
		protected UAkEventCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002C6 RID: 710
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkEventCallbackInfo";

		// Token: 0x040002C7 RID: 711
		private static IntPtr _ClassPtr;

		// Token: 0x040002C8 RID: 712
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002C9 RID: 713
		internal static int __PropertyOffset_PlayingID;

		// Token: 0x040002CA RID: 714
		internal static int __PropertyOffset_EventID;
	}
}
