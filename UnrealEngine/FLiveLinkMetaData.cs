using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002210 RID: 8720
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkMetaData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FLiveLinkMetaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602137B RID: 136059 RVA: 0x0030F8BC File Offset: 0x0030DABC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkMetaData._ScriptStructPtr != 0) ? FLiveLinkMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkMetaData", ref FLiveLinkMetaData._ScriptStructPtr);
		}

		// Token: 0x170081AA RID: 33194
		// (get) Token: 0x0602137C RID: 136060 RVA: 0x0030F8E0 File Offset: 0x0030DAE0
		// (set) Token: 0x0602137D RID: 136061 RVA: 0x0030F923 File Offset: 0x0030DB23
		public TMap<FName, string> StringMetaData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, string> result;
				if ((result = this._StringMetaData) == null)
				{
					result = (this._StringMetaData = new TMap<FName, string>(base.NativePtr + (IntPtr)FLiveLinkMetaData.__PropertyOffset_StringMetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringMetaData.CopyAssign(value);
			}
		}

		// Token: 0x170081AB RID: 33195
		// (get) Token: 0x0602137E RID: 136062 RVA: 0x0030F934 File Offset: 0x0030DB34
		// (set) Token: 0x0602137F RID: 136063 RVA: 0x0030F977 File Offset: 0x0030DB77
		public FQualifiedFrameTime SceneTime
		{
			get
			{
				base.FastCheckIsValid();
				FQualifiedFrameTime result;
				if ((result = this._SceneTime) == null)
				{
					result = (this._SceneTime = new FQualifiedFrameTime(base.NativePtr + (IntPtr)FLiveLinkMetaData.__PropertyOffset_SceneTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQualifiedFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkMetaData.__PropertyOffset_SceneTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021380 RID: 136064 RVA: 0x0030F998 File Offset: 0x0030DB98
		public FLiveLinkMetaData()
		{
		}

		// Token: 0x06021381 RID: 136065 RVA: 0x0030F9A0 File Offset: 0x0030DBA0
		public FLiveLinkMetaData(TMap<FName, string> StringMetaData, FQualifiedFrameTime SceneTime)
		{
			this.StringMetaData = StringMetaData;
			this.SceneTime = SceneTime;
		}

		// Token: 0x06021382 RID: 136066 RVA: 0x0030F9B6 File Offset: 0x0030DBB6
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkMetaData.StaticStruct();
		}

		// Token: 0x06021383 RID: 136067 RVA: 0x0030F9C2 File Offset: 0x0030DBC2
		[NullableContext(2)]
		public FLiveLinkMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021384 RID: 136068 RVA: 0x0030F9CC File Offset: 0x0030DBCC
		public FLiveLinkMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021385 RID: 136069 RVA: 0x0030F9D7 File Offset: 0x0030DBD7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkMetaData(Pointer, false, true);
		}

		// Token: 0x06021386 RID: 136070 RVA: 0x0030F9E1 File Offset: 0x0030DBE1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B85 RID: 72581
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkMetaData";

		// Token: 0x04011B86 RID: 72582
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B87 RID: 72583
		internal static int __PropertyOffset_StringMetaData;

		// Token: 0x04011B88 RID: 72584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, string> _StringMetaData;

		// Token: 0x04011B89 RID: 72585
		internal static int __PropertyOffset_SceneTime;

		// Token: 0x04011B8A RID: 72586
		[Nullable(2)]
		private FQualifiedFrameTime _SceneTime;
	}
}
