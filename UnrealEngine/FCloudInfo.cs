using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E4 RID: 4836
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameMatrix.CloudInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCloudInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011BA0 RID: 72608 RVA: 0x001A0586 File Offset: 0x0019E786
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCloudInfo._ScriptStructPtr != 0) ? FCloudInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.CloudInfo", ref FCloudInfo._ScriptStructPtr);
		}

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x06011BA1 RID: 72609 RVA: 0x001A05AA File Offset: 0x0019E7AA
		// (set) Token: 0x06011BA2 RID: 72610 RVA: 0x001A05BE File Offset: 0x0019E7BE
		public unsafe string DeviceId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCloudInfo.__PropertyOffset_DeviceId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCloudInfo.__PropertyOffset_DeviceId)), value);
			}
		}

		// Token: 0x1700456C RID: 17772
		// (get) Token: 0x06011BA3 RID: 72611 RVA: 0x001A05D3 File Offset: 0x0019E7D3
		// (set) Token: 0x06011BA4 RID: 72612 RVA: 0x001A05E7 File Offset: 0x0019E7E7
		public unsafe string Identity
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCloudInfo.__PropertyOffset_Identity)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCloudInfo.__PropertyOffset_Identity)), value);
			}
		}

		// Token: 0x06011BA5 RID: 72613 RVA: 0x001A05FC File Offset: 0x0019E7FC
		public FCloudInfo()
		{
		}

		// Token: 0x06011BA6 RID: 72614 RVA: 0x001A0604 File Offset: 0x0019E804
		public FCloudInfo(string DeviceId, string Identity)
		{
			this.DeviceId = DeviceId;
			this.Identity = Identity;
		}

		// Token: 0x06011BA7 RID: 72615 RVA: 0x001A061A File Offset: 0x0019E81A
		protected override IntPtr GetUStructPtr()
		{
			return FCloudInfo.StaticStruct();
		}

		// Token: 0x06011BA8 RID: 72616 RVA: 0x001A0626 File Offset: 0x0019E826
		[NullableContext(2)]
		public FCloudInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011BA9 RID: 72617 RVA: 0x001A0630 File Offset: 0x0019E830
		public FCloudInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011BAA RID: 72618 RVA: 0x001A063B File Offset: 0x0019E83B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCloudInfo(Pointer, false, true);
		}

		// Token: 0x06011BAB RID: 72619 RVA: 0x001A0645 File Offset: 0x0019E845
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCloudInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009837 RID: 38967
		public const string __ObjectPath = "/Script/GameMatrix.CloudInfo";

		// Token: 0x04009838 RID: 38968
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009839 RID: 38969
		internal static int __PropertyOffset_DeviceId;

		// Token: 0x0400983A RID: 38970
		internal static int __PropertyOffset_Identity;
	}
}
