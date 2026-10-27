using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A29 RID: 6697
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudCollectionInstance")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroPointCloudCollectionInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018C90 RID: 101520 RVA: 0x0024A096 File Offset: 0x00248296
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointCloudCollectionInstance._ScriptStructPtr != 0) ? FKuroPointCloudCollectionInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointCloudCollectionInstance", ref FKuroPointCloudCollectionInstance._ScriptStructPtr);
		}

		// Token: 0x17006244 RID: 25156
		// (get) Token: 0x06018C91 RID: 101521 RVA: 0x0024A0BA File Offset: 0x002482BA
		// (set) Token: 0x06018C92 RID: 101522 RVA: 0x0024A0CE File Offset: 0x002482CE
		public unsafe FName CollectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointCloudCollectionInstance.__PropertyOffset_CollectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointCloudCollectionInstance.__PropertyOffset_CollectionName) = value;
			}
		}

		// Token: 0x17006245 RID: 25157
		// (get) Token: 0x06018C93 RID: 101523 RVA: 0x0024A0E4 File Offset: 0x002482E4
		// (set) Token: 0x06018C94 RID: 101524 RVA: 0x0024A127 File Offset: 0x00248327
		public FSoftObjectPath Instance
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._Instance) == null)
				{
					result = (this._Instance = new FSoftObjectPath(base.NativePtr + (IntPtr)FKuroPointCloudCollectionInstance.__PropertyOffset_Instance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FKuroPointCloudCollectionInstance.__PropertyOffset_Instance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06018C95 RID: 101525 RVA: 0x0024A148 File Offset: 0x00248348
		public FKuroPointCloudCollectionInstance()
		{
		}

		// Token: 0x06018C96 RID: 101526 RVA: 0x0024A150 File Offset: 0x00248350
		public FKuroPointCloudCollectionInstance(FName CollectionName, FSoftObjectPath Instance)
		{
			this.CollectionName = CollectionName;
			this.Instance = Instance;
		}

		// Token: 0x06018C97 RID: 101527 RVA: 0x0024A166 File Offset: 0x00248366
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointCloudCollectionInstance.StaticStruct();
		}

		// Token: 0x06018C98 RID: 101528 RVA: 0x0024A172 File Offset: 0x00248372
		[NullableContext(2)]
		public FKuroPointCloudCollectionInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018C99 RID: 101529 RVA: 0x0024A17C File Offset: 0x0024837C
		public FKuroPointCloudCollectionInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018C9A RID: 101530 RVA: 0x0024A187 File Offset: 0x00248387
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointCloudCollectionInstance(Pointer, false, true);
		}

		// Token: 0x06018C9B RID: 101531 RVA: 0x0024A191 File Offset: 0x00248391
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointCloudCollectionInstance(Pointer, MemoryOwner);
		}

		// Token: 0x0400D670 RID: 54896
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudCollectionInstance";

		// Token: 0x0400D671 RID: 54897
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D672 RID: 54898
		internal static int __PropertyOffset_CollectionName;

		// Token: 0x0400D673 RID: 54899
		internal static int __PropertyOffset_Instance;

		// Token: 0x0400D674 RID: 54900
		[Nullable(2)]
		private FSoftObjectPath _Instance;
	}
}
