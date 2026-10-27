using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000879 RID: 2169
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneActorPrefab")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FBakedBoneActorPrefab : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007618 RID: 30232 RVA: 0x000A96D6 File Offset: 0x000A78D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneActorPrefab._ScriptStructPtr != 0) ? FBakedBoneActorPrefab._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneActorPrefab", ref FBakedBoneActorPrefab._ScriptStructPtr);
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06007619 RID: 30233 RVA: 0x000A96FA File Offset: 0x000A78FA
		// (set) Token: 0x0600761A RID: 30234 RVA: 0x000A970A File Offset: 0x000A790A
		public unsafe int GroupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_GroupIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_GroupIndex) = value;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x0600761B RID: 30235 RVA: 0x000A971C File Offset: 0x000A791C
		// (set) Token: 0x0600761C RID: 30236 RVA: 0x000A975F File Offset: 0x000A795F
		public FSoftClassPath ActorClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._ActorClass) == null)
				{
					result = (this._ActorClass = new FSoftClassPath(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_ActorClass, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_ActorClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x0600761D RID: 30237 RVA: 0x000A9780 File Offset: 0x000A7980
		// (set) Token: 0x0600761E RID: 30238 RVA: 0x000A9794 File Offset: 0x000A7994
		public unsafe FTransform ActorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_ActorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_ActorTransform) = value;
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x0600761F RID: 30239 RVA: 0x000A97AC File Offset: 0x000A79AC
		// (set) Token: 0x06007620 RID: 30240 RVA: 0x000A97EF File Offset: 0x000A79EF
		public TArray<FBakedBonePrefabProperty> Properties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBonePrefabProperty> result;
				if ((result = this._Properties) == null)
				{
					result = (this._Properties = new TArray<FBakedBonePrefabProperty>(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_Properties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Properties.CopyAssign(value);
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06007621 RID: 30241 RVA: 0x000A97FD File Offset: 0x000A79FD
		// (set) Token: 0x06007622 RID: 30242 RVA: 0x000A9811 File Offset: 0x000A7A11
		public unsafe string ActorLabel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBoneActorPrefab.__PropertyOffset_ActorLabel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBakedBoneActorPrefab.__PropertyOffset_ActorLabel)), value);
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06007623 RID: 30243 RVA: 0x000A9826 File Offset: 0x000A7A26
		// (set) Token: 0x06007624 RID: 30244 RVA: 0x000A983A File Offset: 0x000A7A3A
		public unsafe FName FolderPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_FolderPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneActorPrefab.__PropertyOffset_FolderPath) = value;
			}
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x000A984F File Offset: 0x000A7A4F
		public FBakedBoneActorPrefab()
		{
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x000A9857 File Offset: 0x000A7A57
		public FBakedBoneActorPrefab(int GroupIndex, FSoftClassPath ActorClass, FTransform ActorTransform, TArray<FBakedBonePrefabProperty> Properties, string ActorLabel, FName FolderPath)
		{
			this.GroupIndex = GroupIndex;
			this.ActorClass = ActorClass;
			this.ActorTransform = ActorTransform;
			this.Properties = Properties;
			this.ActorLabel = ActorLabel;
			this.FolderPath = FolderPath;
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x000A988C File Offset: 0x000A7A8C
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneActorPrefab.StaticStruct();
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x000A9898 File Offset: 0x000A7A98
		[NullableContext(2)]
		public FBakedBoneActorPrefab(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x000A98A2 File Offset: 0x000A7AA2
		public FBakedBoneActorPrefab(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x000A98AD File Offset: 0x000A7AAD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneActorPrefab(Pointer, false, true);
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x000A98B7 File Offset: 0x000A7AB7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneActorPrefab(Pointer, MemoryOwner);
		}

		// Token: 0x040038DE RID: 14558
		public const string __ObjectPath = "/Script/Engine.BakedBoneActorPrefab";

		// Token: 0x040038DF RID: 14559
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040038E0 RID: 14560
		internal static int __PropertyOffset_GroupIndex;

		// Token: 0x040038E1 RID: 14561
		internal static int __PropertyOffset_ActorClass;

		// Token: 0x040038E2 RID: 14562
		[Nullable(2)]
		private FSoftClassPath _ActorClass;

		// Token: 0x040038E3 RID: 14563
		internal static int __PropertyOffset_ActorTransform;

		// Token: 0x040038E4 RID: 14564
		internal static int __PropertyOffset_Properties;

		// Token: 0x040038E5 RID: 14565
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBonePrefabProperty> _Properties;

		// Token: 0x040038E6 RID: 14566
		internal static int __PropertyOffset_ActorLabel;

		// Token: 0x040038E7 RID: 14567
		internal static int __PropertyOffset_FolderPath;
	}
}
