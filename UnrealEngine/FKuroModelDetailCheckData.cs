using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CF8 RID: 3320
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroModelDetailCheckData")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 696)]
	public class FKuroModelDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B042 RID: 45122 RVA: 0x000FA0E4 File Offset: 0x000F82E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroModelDetailCheckData._ScriptStructPtr != 0) ? FKuroModelDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroModelDetailCheckData", ref FKuroModelDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0600B043 RID: 45123 RVA: 0x000FA108 File Offset: 0x000F8308
		// (set) Token: 0x0600B044 RID: 45124 RVA: 0x000FA11C File Offset: 0x000F831C
		public unsafe string model_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_model_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_model_path)), value);
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0600B045 RID: 45125 RVA: 0x000FA131 File Offset: 0x000F8331
		// (set) Token: 0x0600B046 RID: 45126 RVA: 0x000FA145 File Offset: 0x000F8345
		public unsafe string model_type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_model_type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_model_type)), value);
			}
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x0600B047 RID: 45127 RVA: 0x000FA15C File Offset: 0x000F835C
		// (set) Token: 0x0600B048 RID: 45128 RVA: 0x000FA19F File Offset: 0x000F839F
		public FKuroModelTypeDetailCheckData model_type_detail
		{
			get
			{
				base.FastCheckIsValid();
				FKuroModelTypeDetailCheckData result;
				if ((result = this._model_type_detail) == null)
				{
					result = (this._model_type_detail = new FKuroModelTypeDetailCheckData(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_model_type_detail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroModelTypeDetailCheckData.StaticStruct(), base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_model_type_detail, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x0600B049 RID: 45129 RVA: 0x000FA1C0 File Offset: 0x000F83C0
		// (set) Token: 0x0600B04A RID: 45130 RVA: 0x000FA1D4 File Offset: 0x000F83D4
		public unsafe string ucx_type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_ucx_type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_ucx_type)), value);
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x000FA1E9 File Offset: 0x000F83E9
		// (set) Token: 0x0600B04C RID: 45132 RVA: 0x000FA1FD File Offset: 0x000F83FD
		public unsafe string collision_complexity
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_collision_complexity)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_collision_complexity)), value);
			}
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x000FA212 File Offset: 0x000F8412
		// (set) Token: 0x0600B04E RID: 45134 RVA: 0x000FA226 File Offset: 0x000F8426
		public unsafe string phy_mat
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_phy_mat)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_phy_mat)), value);
			}
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x0600B04F RID: 45135 RVA: 0x000FA23B File Offset: 0x000F843B
		// (set) Token: 0x0600B050 RID: 45136 RVA: 0x000FA24F File Offset: 0x000F844F
		public unsafe string can_character_step_up_on
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_can_character_step_up_on)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_can_character_step_up_on)), value);
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x0600B051 RID: 45137 RVA: 0x000FA264 File Offset: 0x000F8464
		// (set) Token: 0x0600B052 RID: 45138 RVA: 0x000FA278 File Offset: 0x000F8478
		public unsafe string can_override_mat_in_actor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_can_override_mat_in_actor)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_can_override_mat_in_actor)), value);
			}
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x0600B053 RID: 45139 RVA: 0x000FA28D File Offset: 0x000F848D
		// (set) Token: 0x0600B054 RID: 45140 RVA: 0x000FA29D File Offset: 0x000F849D
		public unsafe bool is_sync_can_character_step_up_on
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_sync_can_character_step_up_on) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_sync_can_character_step_up_on) = (value ? 1 : 0);
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x0600B055 RID: 45141 RVA: 0x000FA2AE File Offset: 0x000F84AE
		// (set) Token: 0x0600B056 RID: 45142 RVA: 0x000FA2BE File Offset: 0x000F84BE
		public unsafe bool is_need_occlusion_mesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_need_occlusion_mesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_need_occlusion_mesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x0600B057 RID: 45143 RVA: 0x000FA2CF File Offset: 0x000F84CF
		// (set) Token: 0x0600B058 RID: 45144 RVA: 0x000FA2DF File Offset: 0x000F84DF
		public unsafe bool is_selective_cook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_selective_cook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_selective_cook) = (value ? 1 : 0);
			}
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x0600B059 RID: 45145 RVA: 0x000FA2F0 File Offset: 0x000F84F0
		// (set) Token: 0x0600B05A RID: 45146 RVA: 0x000FA300 File Offset: 0x000F8500
		public unsafe bool is_use_imposter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_use_imposter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_use_imposter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x0600B05B RID: 45147 RVA: 0x000FA311 File Offset: 0x000F8511
		// (set) Token: 0x0600B05C RID: 45148 RVA: 0x000FA321 File Offset: 0x000F8521
		public unsafe bool is_character_can_stand_on
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_character_can_stand_on) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_is_character_can_stand_on) = (value ? 1 : 0);
			}
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x0600B05D RID: 45149 RVA: 0x000FA332 File Offset: 0x000F8532
		// (set) Token: 0x0600B05E RID: 45150 RVA: 0x000FA346 File Offset: 0x000F8546
		public unsafe string sourcebranch_with_guid_in_whiteList
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_sourcebranch_with_guid_in_whiteList)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelDetailCheckData.__PropertyOffset_sourcebranch_with_guid_in_whiteList)), value);
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x0600B05F RID: 45151 RVA: 0x000FA35C File Offset: 0x000F855C
		// (set) Token: 0x0600B060 RID: 45152 RVA: 0x000FA39F File Offset: 0x000F859F
		public TArray<string> extra_tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._extra_tags) == null)
				{
					result = (this._extra_tags = new TArray<string>(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_extra_tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.extra_tags.CopyAssign(value);
			}
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x0600B061 RID: 45153 RVA: 0x000FA3B0 File Offset: 0x000F85B0
		// (set) Token: 0x0600B062 RID: 45154 RVA: 0x000FA3F3 File Offset: 0x000F85F3
		public TArray<string> detect_tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._detect_tags) == null)
				{
					result = (this._detect_tags = new TArray<string>(base.NativePtr + (IntPtr)FKuroModelDetailCheckData.__PropertyOffset_detect_tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.detect_tags.CopyAssign(value);
			}
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x000FA401 File Offset: 0x000F8601
		public FKuroModelDetailCheckData()
		{
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x000FA40C File Offset: 0x000F860C
		public FKuroModelDetailCheckData(string model_path, string model_type, FKuroModelTypeDetailCheckData model_type_detail, string ucx_type, string collision_complexity, string phy_mat, string can_character_step_up_on, string can_override_mat_in_actor, bool is_sync_can_character_step_up_on, bool is_need_occlusion_mesh, bool is_selective_cook, bool is_use_imposter, bool is_character_can_stand_on, string sourcebranch_with_guid_in_whiteList, TArray<string> extra_tags, TArray<string> detect_tags)
		{
			this.model_path = model_path;
			this.model_type = model_type;
			this.model_type_detail = model_type_detail;
			this.ucx_type = ucx_type;
			this.collision_complexity = collision_complexity;
			this.phy_mat = phy_mat;
			this.can_character_step_up_on = can_character_step_up_on;
			this.can_override_mat_in_actor = can_override_mat_in_actor;
			this.is_sync_can_character_step_up_on = is_sync_can_character_step_up_on;
			this.is_need_occlusion_mesh = is_need_occlusion_mesh;
			this.is_selective_cook = is_selective_cook;
			this.is_use_imposter = is_use_imposter;
			this.is_character_can_stand_on = is_character_can_stand_on;
			this.sourcebranch_with_guid_in_whiteList = sourcebranch_with_guid_in_whiteList;
			this.extra_tags = extra_tags;
			this.detect_tags = detect_tags;
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x000FA49C File Offset: 0x000F869C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroModelDetailCheckData.StaticStruct();
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x000FA4A8 File Offset: 0x000F86A8
		[NullableContext(2)]
		public FKuroModelDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x000FA4B2 File Offset: 0x000F86B2
		public FKuroModelDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x000FA4BD File Offset: 0x000F86BD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroModelDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x000FA4C7 File Offset: 0x000F86C7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroModelDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005C49 RID: 23625
		public const string __ObjectPath = "/Script/Engine.KuroModelDetailCheckData";

		// Token: 0x04005C4A RID: 23626
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C4B RID: 23627
		internal static int __PropertyOffset_model_path;

		// Token: 0x04005C4C RID: 23628
		internal static int __PropertyOffset_model_type;

		// Token: 0x04005C4D RID: 23629
		internal static int __PropertyOffset_model_type_detail;

		// Token: 0x04005C4E RID: 23630
		[Nullable(2)]
		private FKuroModelTypeDetailCheckData _model_type_detail;

		// Token: 0x04005C4F RID: 23631
		internal static int __PropertyOffset_ucx_type;

		// Token: 0x04005C50 RID: 23632
		internal static int __PropertyOffset_collision_complexity;

		// Token: 0x04005C51 RID: 23633
		internal static int __PropertyOffset_phy_mat;

		// Token: 0x04005C52 RID: 23634
		internal static int __PropertyOffset_can_character_step_up_on;

		// Token: 0x04005C53 RID: 23635
		internal static int __PropertyOffset_can_override_mat_in_actor;

		// Token: 0x04005C54 RID: 23636
		internal static int __PropertyOffset_is_sync_can_character_step_up_on;

		// Token: 0x04005C55 RID: 23637
		internal static int __PropertyOffset_is_need_occlusion_mesh;

		// Token: 0x04005C56 RID: 23638
		internal static int __PropertyOffset_is_selective_cook;

		// Token: 0x04005C57 RID: 23639
		internal static int __PropertyOffset_is_use_imposter;

		// Token: 0x04005C58 RID: 23640
		internal static int __PropertyOffset_is_character_can_stand_on;

		// Token: 0x04005C59 RID: 23641
		internal static int __PropertyOffset_sourcebranch_with_guid_in_whiteList;

		// Token: 0x04005C5A RID: 23642
		internal static int __PropertyOffset_extra_tags;

		// Token: 0x04005C5B RID: 23643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _extra_tags;

		// Token: 0x04005C5C RID: 23644
		internal static int __PropertyOffset_detect_tags;

		// Token: 0x04005C5D RID: 23645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _detect_tags;
	}
}
