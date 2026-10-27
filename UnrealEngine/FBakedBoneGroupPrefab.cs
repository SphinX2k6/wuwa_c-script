using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087B RID: 2171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneGroupPrefab")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FBakedBoneGroupPrefab : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007633 RID: 30259 RVA: 0x000A9966 File Offset: 0x000A7B66
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneGroupPrefab._ScriptStructPtr != 0) ? FBakedBoneGroupPrefab._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneGroupPrefab", ref FBakedBoneGroupPrefab._ScriptStructPtr);
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06007634 RID: 30260 RVA: 0x000A998C File Offset: 0x000A7B8C
		// (set) Token: 0x06007635 RID: 30261 RVA: 0x000A99CF File Offset: 0x000A7BCF
		public FSoftClassPath ActorClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._ActorClass) == null)
				{
					result = (this._ActorClass = new FSoftClassPath(base.NativePtr + (IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_ActorClass, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_ActorClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x000A99F0 File Offset: 0x000A7BF0
		// (set) Token: 0x06007637 RID: 30263 RVA: 0x000A9A04 File Offset: 0x000A7C04
		public unsafe FTransform ActorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_ActorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_ActorTransform) = value;
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x000A9A1C File Offset: 0x000A7C1C
		// (set) Token: 0x06007639 RID: 30265 RVA: 0x000A9A5F File Offset: 0x000A7C5F
		public TArray<FBakedBonePrefabProperty> Properties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBonePrefabProperty> result;
				if ((result = this._Properties) == null)
				{
					result = (this._Properties = new TArray<FBakedBonePrefabProperty>(base.NativePtr + (IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_Properties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Properties.CopyAssign(value);
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x000A9A6D File Offset: 0x000A7C6D
		// (set) Token: 0x0600763B RID: 30267 RVA: 0x000A9A81 File Offset: 0x000A7C81
		public unsafe string ActorLabel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_ActorLabel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_ActorLabel)), value);
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x000A9A96 File Offset: 0x000A7C96
		// (set) Token: 0x0600763D RID: 30269 RVA: 0x000A9AAA File Offset: 0x000A7CAA
		public unsafe FName FolderPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_FolderPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneGroupPrefab.__PropertyOffset_FolderPath) = value;
			}
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x000A9ABF File Offset: 0x000A7CBF
		public FBakedBoneGroupPrefab()
		{
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x000A9AC7 File Offset: 0x000A7CC7
		public FBakedBoneGroupPrefab(FSoftClassPath ActorClass, FTransform ActorTransform, TArray<FBakedBonePrefabProperty> Properties, string ActorLabel, FName FolderPath)
		{
			this.ActorClass = ActorClass;
			this.ActorTransform = ActorTransform;
			this.Properties = Properties;
			this.ActorLabel = ActorLabel;
			this.FolderPath = FolderPath;
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x000A9AF4 File Offset: 0x000A7CF4
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneGroupPrefab.StaticStruct();
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x000A9B00 File Offset: 0x000A7D00
		[NullableContext(2)]
		public FBakedBoneGroupPrefab(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x000A9B0A File Offset: 0x000A7D0A
		public FBakedBoneGroupPrefab(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x000A9B15 File Offset: 0x000A7D15
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneGroupPrefab(Pointer, false, true);
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x000A9B1F File Offset: 0x000A7D1F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneGroupPrefab(Pointer, MemoryOwner);
		}

		// Token: 0x040038EB RID: 14571
		public const string __ObjectPath = "/Script/Engine.BakedBoneGroupPrefab";

		// Token: 0x040038EC RID: 14572
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040038ED RID: 14573
		internal static int __PropertyOffset_ActorClass;

		// Token: 0x040038EE RID: 14574
		[Nullable(2)]
		private FSoftClassPath _ActorClass;

		// Token: 0x040038EF RID: 14575
		internal static int __PropertyOffset_ActorTransform;

		// Token: 0x040038F0 RID: 14576
		internal static int __PropertyOffset_Properties;

		// Token: 0x040038F1 RID: 14577
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBonePrefabProperty> _Properties;

		// Token: 0x040038F2 RID: 14578
		internal static int __PropertyOffset_ActorLabel;

		// Token: 0x040038F3 RID: 14579
		internal static int __PropertyOffset_FolderPath;
	}
}
