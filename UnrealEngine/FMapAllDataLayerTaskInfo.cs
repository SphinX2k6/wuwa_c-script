using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D6B RID: 3435
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MapAllDataLayerTaskInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMapAllDataLayerTaskInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B98A RID: 47498 RVA: 0x00107FFC File Offset: 0x001061FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMapAllDataLayerTaskInfo._ScriptStructPtr != 0) ? FMapAllDataLayerTaskInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MapAllDataLayerTaskInfo", ref FMapAllDataLayerTaskInfo._ScriptStructPtr);
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x0600B98B RID: 47499 RVA: 0x00108020 File Offset: 0x00106220
		// (set) Token: 0x0600B98C RID: 47500 RVA: 0x00108063 File Offset: 0x00106263
		public TArray<FMapDataLayerTaskInfo> AllDataLayerTasks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMapDataLayerTaskInfo> result;
				if ((result = this._AllDataLayerTasks) == null)
				{
					result = (this._AllDataLayerTasks = new TArray<FMapDataLayerTaskInfo>(base.NativePtr + (IntPtr)FMapAllDataLayerTaskInfo.__PropertyOffset_AllDataLayerTasks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllDataLayerTasks.CopyAssign(value);
			}
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x00108071 File Offset: 0x00106271
		public FMapAllDataLayerTaskInfo()
		{
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x00108079 File Offset: 0x00106279
		public FMapAllDataLayerTaskInfo(TArray<FMapDataLayerTaskInfo> AllDataLayerTasks)
		{
			this.AllDataLayerTasks = AllDataLayerTasks;
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x00108088 File Offset: 0x00106288
		protected override IntPtr GetUStructPtr()
		{
			return FMapAllDataLayerTaskInfo.StaticStruct();
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x00108094 File Offset: 0x00106294
		[NullableContext(2)]
		public FMapAllDataLayerTaskInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x0010809E File Offset: 0x0010629E
		public FMapAllDataLayerTaskInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x001080A9 File Offset: 0x001062A9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMapAllDataLayerTaskInfo(Pointer, false, true);
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x001080B3 File Offset: 0x001062B3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMapAllDataLayerTaskInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006139 RID: 24889
		public const string __ObjectPath = "/Script/Engine.MapAllDataLayerTaskInfo";

		// Token: 0x0400613A RID: 24890
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400613B RID: 24891
		internal static int __PropertyOffset_AllDataLayerTasks;

		// Token: 0x0400613C RID: 24892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMapDataLayerTaskInfo> _AllDataLayerTasks;
	}
}
