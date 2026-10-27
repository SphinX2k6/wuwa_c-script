using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002729 RID: 10025
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SessionMessages.SessionServicePong")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FSessionServicePong : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025254 RID: 152148 RVA: 0x00370401 File Offset: 0x0036E601
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSessionServicePong._ScriptStructPtr != 0) ? FSessionServicePong._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SessionMessages.SessionServicePong", ref FSessionServicePong._ScriptStructPtr);
		}

		// Token: 0x17008F5A RID: 36698
		// (get) Token: 0x06025255 RID: 152149 RVA: 0x00370425 File Offset: 0x0036E625
		// (set) Token: 0x06025256 RID: 152150 RVA: 0x00370435 File Offset: 0x0036E635
		public unsafe bool Authorized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_Authorized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_Authorized) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008F5B RID: 36699
		// (get) Token: 0x06025257 RID: 152151 RVA: 0x00370446 File Offset: 0x0036E646
		// (set) Token: 0x06025258 RID: 152152 RVA: 0x0037045A File Offset: 0x0036E65A
		public unsafe string BuildDate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_BuildDate)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_BuildDate)), value);
			}
		}

		// Token: 0x17008F5C RID: 36700
		// (get) Token: 0x06025259 RID: 152153 RVA: 0x0037046F File Offset: 0x0036E66F
		// (set) Token: 0x0602525A RID: 152154 RVA: 0x00370483 File Offset: 0x0036E683
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x17008F5D RID: 36701
		// (get) Token: 0x0602525B RID: 152155 RVA: 0x00370498 File Offset: 0x0036E698
		// (set) Token: 0x0602525C RID: 152156 RVA: 0x003704AC File Offset: 0x0036E6AC
		public unsafe FGuid InstanceId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_InstanceId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_InstanceId) = value;
			}
		}

		// Token: 0x17008F5E RID: 36702
		// (get) Token: 0x0602525D RID: 152157 RVA: 0x003704C1 File Offset: 0x0036E6C1
		// (set) Token: 0x0602525E RID: 152158 RVA: 0x003704D5 File Offset: 0x0036E6D5
		public unsafe string InstanceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_InstanceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_InstanceName)), value);
			}
		}

		// Token: 0x17008F5F RID: 36703
		// (get) Token: 0x0602525F RID: 152159 RVA: 0x003704EA File Offset: 0x0036E6EA
		// (set) Token: 0x06025260 RID: 152160 RVA: 0x003704FE File Offset: 0x0036E6FE
		public unsafe string PlatformName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_PlatformName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_PlatformName)), value);
			}
		}

		// Token: 0x17008F60 RID: 36704
		// (get) Token: 0x06025261 RID: 152161 RVA: 0x00370513 File Offset: 0x0036E713
		// (set) Token: 0x06025262 RID: 152162 RVA: 0x00370527 File Offset: 0x0036E727
		public unsafe FGuid SessionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_SessionId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_SessionId) = value;
			}
		}

		// Token: 0x17008F61 RID: 36705
		// (get) Token: 0x06025263 RID: 152163 RVA: 0x0037053C File Offset: 0x0036E73C
		// (set) Token: 0x06025264 RID: 152164 RVA: 0x00370550 File Offset: 0x0036E750
		public unsafe string SessionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_SessionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_SessionName)), value);
			}
		}

		// Token: 0x17008F62 RID: 36706
		// (get) Token: 0x06025265 RID: 152165 RVA: 0x00370565 File Offset: 0x0036E765
		// (set) Token: 0x06025266 RID: 152166 RVA: 0x00370579 File Offset: 0x0036E779
		public unsafe string SessionOwner
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_SessionOwner)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSessionServicePong.__PropertyOffset_SessionOwner)), value);
			}
		}

		// Token: 0x17008F63 RID: 36707
		// (get) Token: 0x06025267 RID: 152167 RVA: 0x0037058E File Offset: 0x0036E78E
		// (set) Token: 0x06025268 RID: 152168 RVA: 0x0037059E File Offset: 0x0036E79E
		public unsafe bool Standalone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_Standalone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSessionServicePong.__PropertyOffset_Standalone) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025269 RID: 152169 RVA: 0x003705AF File Offset: 0x0036E7AF
		public FSessionServicePong()
		{
		}

		// Token: 0x0602526A RID: 152170 RVA: 0x003705B8 File Offset: 0x0036E7B8
		public FSessionServicePong(bool Authorized, string BuildDate, string DeviceName, FGuid InstanceId, string InstanceName, string PlatformName, FGuid SessionId, string SessionName, string SessionOwner, bool Standalone)
		{
			this.Authorized = Authorized;
			this.BuildDate = BuildDate;
			this.DeviceName = DeviceName;
			this.InstanceId = InstanceId;
			this.InstanceName = InstanceName;
			this.PlatformName = PlatformName;
			this.SessionId = SessionId;
			this.SessionName = SessionName;
			this.SessionOwner = SessionOwner;
			this.Standalone = Standalone;
		}

		// Token: 0x0602526B RID: 152171 RVA: 0x00370618 File Offset: 0x0036E818
		protected override IntPtr GetUStructPtr()
		{
			return FSessionServicePong.StaticStruct();
		}

		// Token: 0x0602526C RID: 152172 RVA: 0x00370624 File Offset: 0x0036E824
		[NullableContext(2)]
		public FSessionServicePong(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602526D RID: 152173 RVA: 0x0037062E File Offset: 0x0036E82E
		public FSessionServicePong(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602526E RID: 152174 RVA: 0x00370639 File Offset: 0x0036E839
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSessionServicePong(Pointer, false, true);
		}

		// Token: 0x0602526F RID: 152175 RVA: 0x00370643 File Offset: 0x0036E843
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSessionServicePong(Pointer, MemoryOwner);
		}

		// Token: 0x04014042 RID: 81986
		public const string __ObjectPath = "/Script/SessionMessages.SessionServicePong";

		// Token: 0x04014043 RID: 81987
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014044 RID: 81988
		internal static int __PropertyOffset_Authorized;

		// Token: 0x04014045 RID: 81989
		internal static int __PropertyOffset_BuildDate;

		// Token: 0x04014046 RID: 81990
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x04014047 RID: 81991
		internal static int __PropertyOffset_InstanceId;

		// Token: 0x04014048 RID: 81992
		internal static int __PropertyOffset_InstanceName;

		// Token: 0x04014049 RID: 81993
		internal static int __PropertyOffset_PlatformName;

		// Token: 0x0401404A RID: 81994
		internal static int __PropertyOffset_SessionId;

		// Token: 0x0401404B RID: 81995
		internal static int __PropertyOffset_SessionName;

		// Token: 0x0401404C RID: 81996
		internal static int __PropertyOffset_SessionOwner;

		// Token: 0x0401404D RID: 81997
		internal static int __PropertyOffset_Standalone;
	}
}
