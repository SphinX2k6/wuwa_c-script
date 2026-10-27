using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CF9 RID: 3321
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroModelTypeDetailCheckData")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 528)]
	public class FKuroModelTypeDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B06A RID: 45162 RVA: 0x000FA4D0 File Offset: 0x000F86D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroModelTypeDetailCheckData._ScriptStructPtr != 0) ? FKuroModelTypeDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroModelTypeDetailCheckData", ref FKuroModelTypeDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x0600B06B RID: 45163 RVA: 0x000FA4F4 File Offset: 0x000F86F4
		// (set) Token: 0x0600B06C RID: 45164 RVA: 0x000FA508 File Offset: 0x000F8708
		public unsafe string type_name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_type_name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_type_name)), value);
			}
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x0600B06D RID: 45165 RVA: 0x000FA51D File Offset: 0x000F871D
		// (set) Token: 0x0600B06E RID: 45166 RVA: 0x000FA531 File Offset: 0x000F8731
		public unsafe string parent_type_name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_parent_type_name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_parent_type_name)), value);
			}
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x0600B06F RID: 45167 RVA: 0x000FA548 File Offset: 0x000F8748
		// (set) Token: 0x0600B070 RID: 45168 RVA: 0x000FA58B File Offset: 0x000F878B
		public TArray<int> lod_prim_limit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._lod_prim_limit) == null)
				{
					result = (this._lod_prim_limit = new TArray<int>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_lod_prim_limit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.lod_prim_limit.CopyAssign(value);
			}
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600B071 RID: 45169 RVA: 0x000FA59C File Offset: 0x000F879C
		// (set) Token: 0x0600B072 RID: 45170 RVA: 0x000FA5DF File Offset: 0x000F87DF
		public TArray<float> adjoin_lod_prim_gap_limit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._adjoin_lod_prim_gap_limit) == null)
				{
					result = (this._adjoin_lod_prim_gap_limit = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_adjoin_lod_prim_gap_limit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.adjoin_lod_prim_gap_limit.CopyAssign(value);
			}
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600B073 RID: 45171 RVA: 0x000FA5F0 File Offset: 0x000F87F0
		// (set) Token: 0x0600B074 RID: 45172 RVA: 0x000FA633 File Offset: 0x000F8833
		public TArray<float> adjoin_lod_prim_gap_max_limit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._adjoin_lod_prim_gap_max_limit) == null)
				{
					result = (this._adjoin_lod_prim_gap_max_limit = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_adjoin_lod_prim_gap_max_limit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.adjoin_lod_prim_gap_max_limit.CopyAssign(value);
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0600B075 RID: 45173 RVA: 0x000FA641 File Offset: 0x000F8841
		// (set) Token: 0x0600B076 RID: 45174 RVA: 0x000FA651 File Offset: 0x000F8851
		public unsafe int hlod_prim_limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_hlod_prim_limit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_hlod_prim_limit) = value;
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x0600B077 RID: 45175 RVA: 0x000FA662 File Offset: 0x000F8862
		// (set) Token: 0x0600B078 RID: 45176 RVA: 0x000FA676 File Offset: 0x000F8876
		public unsafe string streaming_grid
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_streaming_grid)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_streaming_grid)), value);
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0600B079 RID: 45177 RVA: 0x000FA68B File Offset: 0x000F888B
		// (set) Token: 0x0600B07A RID: 45178 RVA: 0x000FA69B File Offset: 0x000F889B
		public unsafe int bound_box_length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_bound_box_length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_bound_box_length) = value;
			}
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x000FA6AC File Offset: 0x000F88AC
		// (set) Token: 0x0600B07C RID: 45180 RVA: 0x000FA6BC File Offset: 0x000F88BC
		public unsafe int bound_box_min_length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_bound_box_min_length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_bound_box_min_length) = value;
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0600B07D RID: 45181 RVA: 0x000FA6CD File Offset: 0x000F88CD
		// (set) Token: 0x0600B07E RID: 45182 RVA: 0x000FA6E1 File Offset: 0x000F88E1
		public unsafe string kuro_streaming_group
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_streaming_group)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_streaming_group)), value);
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x0600B07F RID: 45183 RVA: 0x000FA6F6 File Offset: 0x000F88F6
		// (set) Token: 0x0600B080 RID: 45184 RVA: 0x000FA706 File Offset: 0x000F8906
		public unsafe int collision_prim_limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_collision_prim_limit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_collision_prim_limit) = value;
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600B081 RID: 45185 RVA: 0x000FA717 File Offset: 0x000F8917
		// (set) Token: 0x0600B082 RID: 45186 RVA: 0x000FA727 File Offset: 0x000F8927
		public unsafe float max_sacle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_sacle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_sacle) = value;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x000FA738 File Offset: 0x000F8938
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x000FA748 File Offset: 0x000F8948
		public unsafe float min_scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_min_scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_min_scale) = value;
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x0600B085 RID: 45189 RVA: 0x000FA759 File Offset: 0x000F8959
		// (set) Token: 0x0600B086 RID: 45190 RVA: 0x000FA769 File Offset: 0x000F8969
		public unsafe float scale_max_allowed_difference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_scale_max_allowed_difference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_scale_max_allowed_difference) = value;
			}
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x0600B087 RID: 45191 RVA: 0x000FA77A File Offset: 0x000F897A
		// (set) Token: 0x0600B088 RID: 45192 RVA: 0x000FA78A File Offset: 0x000F898A
		public unsafe float screen_size_cull_ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_cull_ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_cull_ratio) = value;
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x0600B089 RID: 45193 RVA: 0x000FA79B File Offset: 0x000F899B
		// (set) Token: 0x0600B08A RID: 45194 RVA: 0x000FA7AB File Offset: 0x000F89AB
		public unsafe float max_screen_size_cull_ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_screen_size_cull_ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_screen_size_cull_ratio) = value;
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x0600B08B RID: 45195 RVA: 0x000FA7BC File Offset: 0x000F89BC
		// (set) Token: 0x0600B08C RID: 45196 RVA: 0x000FA7FF File Offset: 0x000F89FF
		public TArray<string> platform_setting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._platform_setting) == null)
				{
					result = (this._platform_setting = new TArray<string>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_platform_setting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.platform_setting.CopyAssign(value);
			}
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x0600B08D RID: 45197 RVA: 0x000FA810 File Offset: 0x000F8A10
		// (set) Token: 0x0600B08E RID: 45198 RVA: 0x000FA853 File Offset: 0x000F8A53
		public TArray<int> platform_min_lod
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._platform_min_lod) == null)
				{
					result = (this._platform_min_lod = new TArray<int>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_platform_min_lod, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.platform_min_lod.CopyAssign(value);
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x0600B08F RID: 45199 RVA: 0x000FA864 File Offset: 0x000F8A64
		// (set) Token: 0x0600B090 RID: 45200 RVA: 0x000FA8A7 File Offset: 0x000F8AA7
		public TArray<string> device_level_extra_lod_bias_platform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._device_level_extra_lod_bias_platform) == null)
				{
					result = (this._device_level_extra_lod_bias_platform = new TArray<string>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_device_level_extra_lod_bias_platform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.device_level_extra_lod_bias_platform.CopyAssign(value);
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x0600B091 RID: 45201 RVA: 0x000FA8B8 File Offset: 0x000F8AB8
		// (set) Token: 0x0600B092 RID: 45202 RVA: 0x000FA8FB File Offset: 0x000F8AFB
		public TArray<int> device_level_extra_lod_bias
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._device_level_extra_lod_bias) == null)
				{
					result = (this._device_level_extra_lod_bias = new TArray<int>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_device_level_extra_lod_bias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.device_level_extra_lod_bias.CopyAssign(value);
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x0600B093 RID: 45203 RVA: 0x000FA90C File Offset: 0x000F8B0C
		// (set) Token: 0x0600B094 RID: 45204 RVA: 0x000FA94F File Offset: 0x000F8B4F
		public TArray<int> device_level_extra_lod_bias_effected_level
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._device_level_extra_lod_bias_effected_level) == null)
				{
					result = (this._device_level_extra_lod_bias_effected_level = new TArray<int>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_device_level_extra_lod_bias_effected_level, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.device_level_extra_lod_bias_effected_level.CopyAssign(value);
			}
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600B095 RID: 45205 RVA: 0x000FA95D File Offset: 0x000F8B5D
		// (set) Token: 0x0600B096 RID: 45206 RVA: 0x000FA96D File Offset: 0x000F8B6D
		public unsafe float extended_bound_sphere_radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_extended_bound_sphere_radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_extended_bound_sphere_radius) = value;
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600B097 RID: 45207 RVA: 0x000FA97E File Offset: 0x000F8B7E
		// (set) Token: 0x0600B098 RID: 45208 RVA: 0x000FA98E File Offset: 0x000F8B8E
		public unsafe float screen_size_gradient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_gradient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_gradient) = value;
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600B099 RID: 45209 RVA: 0x000FA99F File Offset: 0x000F8B9F
		// (set) Token: 0x0600B09A RID: 45210 RVA: 0x000FA9AF File Offset: 0x000F8BAF
		public unsafe sbyte use_kuro_lod_distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_use_kuro_lod_distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_use_kuro_lod_distance) = (byte)value;
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x0600B09B RID: 45211 RVA: 0x000FA9C0 File Offset: 0x000F8BC0
		// (set) Token: 0x0600B09C RID: 45212 RVA: 0x000FAA03 File Offset: 0x000F8C03
		public TArray<float> screen_size_pc
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._screen_size_pc) == null)
				{
					result = (this._screen_size_pc = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_pc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.screen_size_pc.CopyAssign(value);
			}
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x0600B09D RID: 45213 RVA: 0x000FAA14 File Offset: 0x000F8C14
		// (set) Token: 0x0600B09E RID: 45214 RVA: 0x000FAA57 File Offset: 0x000F8C57
		public TArray<float> screen_size_pc_min
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._screen_size_pc_min) == null)
				{
					result = (this._screen_size_pc_min = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_pc_min, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.screen_size_pc_min.CopyAssign(value);
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0600B09F RID: 45215 RVA: 0x000FAA68 File Offset: 0x000F8C68
		// (set) Token: 0x0600B0A0 RID: 45216 RVA: 0x000FAAAB File Offset: 0x000F8CAB
		public TArray<float> screen_size_mobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._screen_size_mobile) == null)
				{
					result = (this._screen_size_mobile = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_mobile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.screen_size_mobile.CopyAssign(value);
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0600B0A1 RID: 45217 RVA: 0x000FAABC File Offset: 0x000F8CBC
		// (set) Token: 0x0600B0A2 RID: 45218 RVA: 0x000FAAFF File Offset: 0x000F8CFF
		public TArray<float> screen_size_mobile_min
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._screen_size_mobile_min) == null)
				{
					result = (this._screen_size_mobile_min = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_mobile_min, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.screen_size_mobile_min.CopyAssign(value);
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x000FAB0D File Offset: 0x000F8D0D
		// (set) Token: 0x0600B0A4 RID: 45220 RVA: 0x000FAB1D File Offset: 0x000F8D1D
		public unsafe float screen_size_cross_border_down_rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_cross_border_down_rate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_screen_size_cross_border_down_rate) = value;
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x000FAB30 File Offset: 0x000F8D30
		// (set) Token: 0x0600B0A6 RID: 45222 RVA: 0x000FAB73 File Offset: 0x000F8D73
		public TArray<float> kuro_lod_distance_pc
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._kuro_lod_distance_pc) == null)
				{
					result = (this._kuro_lod_distance_pc = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_lod_distance_pc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.kuro_lod_distance_pc.CopyAssign(value);
			}
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600B0A7 RID: 45223 RVA: 0x000FAB84 File Offset: 0x000F8D84
		// (set) Token: 0x0600B0A8 RID: 45224 RVA: 0x000FABC7 File Offset: 0x000F8DC7
		public TArray<float> kuro_lod_distance_pc_max
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._kuro_lod_distance_pc_max) == null)
				{
					result = (this._kuro_lod_distance_pc_max = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_lod_distance_pc_max, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.kuro_lod_distance_pc_max.CopyAssign(value);
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600B0A9 RID: 45225 RVA: 0x000FABD8 File Offset: 0x000F8DD8
		// (set) Token: 0x0600B0AA RID: 45226 RVA: 0x000FAC1B File Offset: 0x000F8E1B
		public TArray<float> kuro_lod_distance_mobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._kuro_lod_distance_mobile) == null)
				{
					result = (this._kuro_lod_distance_mobile = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_lod_distance_mobile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.kuro_lod_distance_mobile.CopyAssign(value);
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600B0AB RID: 45227 RVA: 0x000FAC2C File Offset: 0x000F8E2C
		// (set) Token: 0x0600B0AC RID: 45228 RVA: 0x000FAC6F File Offset: 0x000F8E6F
		public TArray<float> kuro_lod_distance_mobile_max
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._kuro_lod_distance_mobile_max) == null)
				{
					result = (this._kuro_lod_distance_mobile_max = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_lod_distance_mobile_max, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.kuro_lod_distance_mobile_max.CopyAssign(value);
			}
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600B0AD RID: 45229 RVA: 0x000FAC7D File Offset: 0x000F8E7D
		// (set) Token: 0x0600B0AE RID: 45230 RVA: 0x000FAC8D File Offset: 0x000F8E8D
		public unsafe float kuro_lod_distance_cross_border_scale_rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_lod_distance_cross_border_scale_rate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_kuro_lod_distance_cross_border_scale_rate) = value;
			}
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x0600B0AF RID: 45231 RVA: 0x000FAC9E File Offset: 0x000F8E9E
		// (set) Token: 0x0600B0B0 RID: 45232 RVA: 0x000FACAE File Offset: 0x000F8EAE
		public unsafe float instance_count_score
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_instance_count_score);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_instance_count_score) = value;
			}
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x0600B0B1 RID: 45233 RVA: 0x000FACBF File Offset: 0x000F8EBF
		// (set) Token: 0x0600B0B2 RID: 45234 RVA: 0x000FACCF File Offset: 0x000F8ECF
		public unsafe float instance_type_count_score
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_instance_type_count_score);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_instance_type_count_score) = value;
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x0600B0B3 RID: 45235 RVA: 0x000FACE0 File Offset: 0x000F8EE0
		// (set) Token: 0x0600B0B4 RID: 45236 RVA: 0x000FAD23 File Offset: 0x000F8F23
		public TArray<string> tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._tags) == null)
				{
					result = (this._tags = new TArray<string>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.tags.CopyAssign(value);
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x0600B0B5 RID: 45237 RVA: 0x000FAD34 File Offset: 0x000F8F34
		// (set) Token: 0x0600B0B6 RID: 45238 RVA: 0x000FAD77 File Offset: 0x000F8F77
		public TArray<string> lod_mat_path
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._lod_mat_path) == null)
				{
					result = (this._lod_mat_path = new TArray<string>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_lod_mat_path, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.lod_mat_path.CopyAssign(value);
			}
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x0600B0B7 RID: 45239 RVA: 0x000FAD85 File Offset: 0x000F8F85
		// (set) Token: 0x0600B0B8 RID: 45240 RVA: 0x000FAD95 File Offset: 0x000F8F95
		public unsafe float texture_count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_texture_count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_texture_count) = value;
			}
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x0600B0B9 RID: 45241 RVA: 0x000FADA6 File Offset: 0x000F8FA6
		// (set) Token: 0x0600B0BA RID: 45242 RVA: 0x000FADB6 File Offset: 0x000F8FB6
		public unsafe float texture_count_mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_texture_count_mobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_texture_count_mobile) = value;
			}
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x0600B0BB RID: 45243 RVA: 0x000FADC8 File Offset: 0x000F8FC8
		// (set) Token: 0x0600B0BC RID: 45244 RVA: 0x000FAE0B File Offset: 0x000F900B
		public TArray<byte> part_count
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._part_count) == null)
				{
					result = (this._part_count = new TArray<byte>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_part_count, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.part_count.CopyAssign(value);
			}
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x0600B0BD RID: 45245 RVA: 0x000FAE19 File Offset: 0x000F9019
		// (set) Token: 0x0600B0BE RID: 45246 RVA: 0x000FAE29 File Offset: 0x000F9029
		public unsafe byte uv_count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_uv_count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_uv_count) = value;
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x0600B0BF RID: 45247 RVA: 0x000FAE3A File Offset: 0x000F903A
		// (set) Token: 0x0600B0C0 RID: 45248 RVA: 0x000FAE4A File Offset: 0x000F904A
		public unsafe byte lod_mat_num
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_lod_mat_num);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_lod_mat_num) = value;
			}
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x0600B0C1 RID: 45249 RVA: 0x000FAE5B File Offset: 0x000F905B
		// (set) Token: 0x0600B0C2 RID: 45250 RVA: 0x000FAE6F File Offset: 0x000F906F
		public unsafe string open_mobile_shadow
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_open_mobile_shadow)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_open_mobile_shadow)), value);
			}
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x0600B0C3 RID: 45251 RVA: 0x000FAE84 File Offset: 0x000F9084
		// (set) Token: 0x0600B0C4 RID: 45252 RVA: 0x000FAE9D File Offset: 0x000F909D
		public unsafe bool can_override_mat_in_actor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_can_override_mat_in_actor) & FKuroModelTypeDetailCheckData.__PropertyMask_can_override_mat_in_actor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_can_override_mat_in_actor) = ((*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_can_override_mat_in_actor) & ~FKuroModelTypeDetailCheckData.__PropertyMask_can_override_mat_in_actor) | (value ? FKuroModelTypeDetailCheckData.__PropertyMask_can_override_mat_in_actor : 0));
			}
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x0600B0C5 RID: 45253 RVA: 0x000FAECD File Offset: 0x000F90CD
		// (set) Token: 0x0600B0C6 RID: 45254 RVA: 0x000FAEE6 File Offset: 0x000F90E6
		public unsafe bool is_open_far_shadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_is_open_far_shadow) & FKuroModelTypeDetailCheckData.__PropertyMask_is_open_far_shadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_is_open_far_shadow) = ((*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_is_open_far_shadow) & ~FKuroModelTypeDetailCheckData.__PropertyMask_is_open_far_shadow) | (value ? FKuroModelTypeDetailCheckData.__PropertyMask_is_open_far_shadow : 0));
			}
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600B0C7 RID: 45255 RVA: 0x000FAF16 File Offset: 0x000F9116
		// (set) Token: 0x0600B0C8 RID: 45256 RVA: 0x000FAF2F File Offset: 0x000F912F
		public unsafe bool is_open_vertex_compress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_is_open_vertex_compress) & FKuroModelTypeDetailCheckData.__PropertyMask_is_open_vertex_compress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_is_open_vertex_compress) = ((*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_is_open_vertex_compress) & ~FKuroModelTypeDetailCheckData.__PropertyMask_is_open_vertex_compress) | (value ? FKuroModelTypeDetailCheckData.__PropertyMask_is_open_vertex_compress : 0));
			}
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0600B0C9 RID: 45257 RVA: 0x000FAF5F File Offset: 0x000F915F
		// (set) Token: 0x0600B0CA RID: 45258 RVA: 0x000FAF78 File Offset: 0x000F9178
		public unsafe bool ray_tracing_OMM
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_ray_tracing_OMM) & FKuroModelTypeDetailCheckData.__PropertyMask_ray_tracing_OMM) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_ray_tracing_OMM) = ((*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_ray_tracing_OMM) & ~FKuroModelTypeDetailCheckData.__PropertyMask_ray_tracing_OMM) | (value ? FKuroModelTypeDetailCheckData.__PropertyMask_ray_tracing_OMM : 0));
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x0600B0CB RID: 45259 RVA: 0x000FAFA8 File Offset: 0x000F91A8
		// (set) Token: 0x0600B0CC RID: 45260 RVA: 0x000FAFC1 File Offset: 0x000F91C1
		public unsafe bool can_be_hlod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_can_be_hlod) & FKuroModelTypeDetailCheckData.__PropertyMask_can_be_hlod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_can_be_hlod) = ((*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_can_be_hlod) & ~FKuroModelTypeDetailCheckData.__PropertyMask_can_be_hlod) | (value ? FKuroModelTypeDetailCheckData.__PropertyMask_can_be_hlod : 0));
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x0600B0CD RID: 45261 RVA: 0x000FAFF1 File Offset: 0x000F91F1
		// (set) Token: 0x0600B0CE RID: 45262 RVA: 0x000FB00A File Offset: 0x000F920A
		public unsafe bool mesh_distance_field
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_mesh_distance_field) & FKuroModelTypeDetailCheckData.__PropertyMask_mesh_distance_field) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_mesh_distance_field) = ((*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_mesh_distance_field) & ~FKuroModelTypeDetailCheckData.__PropertyMask_mesh_distance_field) | (value ? FKuroModelTypeDetailCheckData.__PropertyMask_mesh_distance_field : 0));
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600B0CF RID: 45263 RVA: 0x000FB03A File Offset: 0x000F923A
		// (set) Token: 0x0600B0D0 RID: 45264 RVA: 0x000FB04A File Offset: 0x000F924A
		public unsafe float desktop_maximal_triangle_density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_desktop_maximal_triangle_density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_desktop_maximal_triangle_density) = value;
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x0600B0D1 RID: 45265 RVA: 0x000FB05B File Offset: 0x000F925B
		// (set) Token: 0x0600B0D2 RID: 45266 RVA: 0x000FB06B File Offset: 0x000F926B
		public unsafe float mobile_maximal_triangle_density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_mobile_maximal_triangle_density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_mobile_maximal_triangle_density) = value;
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x000FB07C File Offset: 0x000F927C
		// (set) Token: 0x0600B0D4 RID: 45268 RVA: 0x000FB08C File Offset: 0x000F928C
		public unsafe float max_allowed_mesh_reduction_percentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_allowed_mesh_reduction_percentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_allowed_mesh_reduction_percentage) = value;
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600B0D5 RID: 45269 RVA: 0x000FB09D File Offset: 0x000F929D
		// (set) Token: 0x0600B0D6 RID: 45270 RVA: 0x000FB0AD File Offset: 0x000F92AD
		public unsafe float max_allowed_micro_triangle_percentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_allowed_micro_triangle_percentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_max_allowed_micro_triangle_percentage) = value;
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x0600B0D7 RID: 45271 RVA: 0x000FB0C0 File Offset: 0x000F92C0
		// (set) Token: 0x0600B0D8 RID: 45272 RVA: 0x000FB103 File Offset: 0x000F9303
		public TArray<float> multiplatform_triangle_ratio
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._multiplatform_triangle_ratio) == null)
				{
					result = (this._multiplatform_triangle_ratio = new TArray<float>(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_multiplatform_triangle_ratio, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.multiplatform_triangle_ratio.CopyAssign(value);
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x0600B0D9 RID: 45273 RVA: 0x000FB111 File Offset: 0x000F9311
		// (set) Token: 0x0600B0DA RID: 45274 RVA: 0x000FB121 File Offset: 0x000F9321
		public unsafe bool force_multiplatform_da_detect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_force_multiplatform_da_detect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroModelTypeDetailCheckData.__PropertyOffset_force_multiplatform_da_detect) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x000FB132 File Offset: 0x000F9332
		public FKuroModelTypeDetailCheckData()
		{
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x000FB13C File Offset: 0x000F933C
		public FKuroModelTypeDetailCheckData(string type_name, string parent_type_name, TArray<int> lod_prim_limit, TArray<float> adjoin_lod_prim_gap_limit, TArray<float> adjoin_lod_prim_gap_max_limit, int hlod_prim_limit, string streaming_grid, int bound_box_length, int bound_box_min_length, string kuro_streaming_group, int collision_prim_limit, float max_sacle, float min_scale, float scale_max_allowed_difference, float screen_size_cull_ratio, float max_screen_size_cull_ratio, TArray<string> platform_setting, TArray<int> platform_min_lod, TArray<string> device_level_extra_lod_bias_platform, TArray<int> device_level_extra_lod_bias, TArray<int> device_level_extra_lod_bias_effected_level, float extended_bound_sphere_radius, float screen_size_gradient, sbyte use_kuro_lod_distance, TArray<float> screen_size_pc, TArray<float> screen_size_pc_min, TArray<float> screen_size_mobile, TArray<float> screen_size_mobile_min, float screen_size_cross_border_down_rate, TArray<float> kuro_lod_distance_pc, TArray<float> kuro_lod_distance_pc_max, TArray<float> kuro_lod_distance_mobile, TArray<float> kuro_lod_distance_mobile_max, float kuro_lod_distance_cross_border_scale_rate, float instance_count_score, float instance_type_count_score, TArray<string> tags, TArray<string> lod_mat_path, float texture_count, float texture_count_mobile, TArray<byte> part_count, byte uv_count, byte lod_mat_num, string open_mobile_shadow, bool can_override_mat_in_actor, bool is_open_far_shadow, bool is_open_vertex_compress, bool ray_tracing_OMM, bool can_be_hlod, bool mesh_distance_field, float desktop_maximal_triangle_density, float mobile_maximal_triangle_density, float max_allowed_mesh_reduction_percentage, float max_allowed_micro_triangle_percentage, TArray<float> multiplatform_triangle_ratio, bool force_multiplatform_da_detect)
		{
			this.type_name = type_name;
			this.parent_type_name = parent_type_name;
			this.lod_prim_limit = lod_prim_limit;
			this.adjoin_lod_prim_gap_limit = adjoin_lod_prim_gap_limit;
			this.adjoin_lod_prim_gap_max_limit = adjoin_lod_prim_gap_max_limit;
			this.hlod_prim_limit = hlod_prim_limit;
			this.streaming_grid = streaming_grid;
			this.bound_box_length = bound_box_length;
			this.bound_box_min_length = bound_box_min_length;
			this.kuro_streaming_group = kuro_streaming_group;
			this.collision_prim_limit = collision_prim_limit;
			this.max_sacle = max_sacle;
			this.min_scale = min_scale;
			this.scale_max_allowed_difference = scale_max_allowed_difference;
			this.screen_size_cull_ratio = screen_size_cull_ratio;
			this.max_screen_size_cull_ratio = max_screen_size_cull_ratio;
			this.platform_setting = platform_setting;
			this.platform_min_lod = platform_min_lod;
			this.device_level_extra_lod_bias_platform = device_level_extra_lod_bias_platform;
			this.device_level_extra_lod_bias = device_level_extra_lod_bias;
			this.device_level_extra_lod_bias_effected_level = device_level_extra_lod_bias_effected_level;
			this.extended_bound_sphere_radius = extended_bound_sphere_radius;
			this.screen_size_gradient = screen_size_gradient;
			this.use_kuro_lod_distance = use_kuro_lod_distance;
			this.screen_size_pc = screen_size_pc;
			this.screen_size_pc_min = screen_size_pc_min;
			this.screen_size_mobile = screen_size_mobile;
			this.screen_size_mobile_min = screen_size_mobile_min;
			this.screen_size_cross_border_down_rate = screen_size_cross_border_down_rate;
			this.kuro_lod_distance_pc = kuro_lod_distance_pc;
			this.kuro_lod_distance_pc_max = kuro_lod_distance_pc_max;
			this.kuro_lod_distance_mobile = kuro_lod_distance_mobile;
			this.kuro_lod_distance_mobile_max = kuro_lod_distance_mobile_max;
			this.kuro_lod_distance_cross_border_scale_rate = kuro_lod_distance_cross_border_scale_rate;
			this.instance_count_score = instance_count_score;
			this.instance_type_count_score = instance_type_count_score;
			this.tags = tags;
			this.lod_mat_path = lod_mat_path;
			this.texture_count = texture_count;
			this.texture_count_mobile = texture_count_mobile;
			this.part_count = part_count;
			this.uv_count = uv_count;
			this.lod_mat_num = lod_mat_num;
			this.open_mobile_shadow = open_mobile_shadow;
			this.can_override_mat_in_actor = can_override_mat_in_actor;
			this.is_open_far_shadow = is_open_far_shadow;
			this.is_open_vertex_compress = is_open_vertex_compress;
			this.ray_tracing_OMM = ray_tracing_OMM;
			this.can_be_hlod = can_be_hlod;
			this.mesh_distance_field = mesh_distance_field;
			this.desktop_maximal_triangle_density = desktop_maximal_triangle_density;
			this.mobile_maximal_triangle_density = mobile_maximal_triangle_density;
			this.max_allowed_mesh_reduction_percentage = max_allowed_mesh_reduction_percentage;
			this.max_allowed_micro_triangle_percentage = max_allowed_micro_triangle_percentage;
			this.multiplatform_triangle_ratio = multiplatform_triangle_ratio;
			this.force_multiplatform_da_detect = force_multiplatform_da_detect;
		}

		// Token: 0x0600B0DD RID: 45277 RVA: 0x000FB30C File Offset: 0x000F950C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroModelTypeDetailCheckData.StaticStruct();
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x000FB318 File Offset: 0x000F9518
		[NullableContext(2)]
		public FKuroModelTypeDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x000FB322 File Offset: 0x000F9522
		public FKuroModelTypeDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x000FB32D File Offset: 0x000F952D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroModelTypeDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x000FB337 File Offset: 0x000F9537
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroModelTypeDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005C5E RID: 23646
		public const string __ObjectPath = "/Script/Engine.KuroModelTypeDetailCheckData";

		// Token: 0x04005C5F RID: 23647
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C60 RID: 23648
		internal static int __PropertyOffset_type_name;

		// Token: 0x04005C61 RID: 23649
		internal static int __PropertyOffset_parent_type_name;

		// Token: 0x04005C62 RID: 23650
		internal static int __PropertyOffset_lod_prim_limit;

		// Token: 0x04005C63 RID: 23651
		[Nullable(2)]
		private TArray<int> _lod_prim_limit;

		// Token: 0x04005C64 RID: 23652
		internal static int __PropertyOffset_adjoin_lod_prim_gap_limit;

		// Token: 0x04005C65 RID: 23653
		[Nullable(2)]
		private TArray<float> _adjoin_lod_prim_gap_limit;

		// Token: 0x04005C66 RID: 23654
		internal static int __PropertyOffset_adjoin_lod_prim_gap_max_limit;

		// Token: 0x04005C67 RID: 23655
		[Nullable(2)]
		private TArray<float> _adjoin_lod_prim_gap_max_limit;

		// Token: 0x04005C68 RID: 23656
		internal static int __PropertyOffset_hlod_prim_limit;

		// Token: 0x04005C69 RID: 23657
		internal static int __PropertyOffset_streaming_grid;

		// Token: 0x04005C6A RID: 23658
		internal static int __PropertyOffset_bound_box_length;

		// Token: 0x04005C6B RID: 23659
		internal static int __PropertyOffset_bound_box_min_length;

		// Token: 0x04005C6C RID: 23660
		internal static int __PropertyOffset_kuro_streaming_group;

		// Token: 0x04005C6D RID: 23661
		internal static int __PropertyOffset_collision_prim_limit;

		// Token: 0x04005C6E RID: 23662
		internal static int __PropertyOffset_max_sacle;

		// Token: 0x04005C6F RID: 23663
		internal static int __PropertyOffset_min_scale;

		// Token: 0x04005C70 RID: 23664
		internal static int __PropertyOffset_scale_max_allowed_difference;

		// Token: 0x04005C71 RID: 23665
		internal static int __PropertyOffset_screen_size_cull_ratio;

		// Token: 0x04005C72 RID: 23666
		internal static int __PropertyOffset_max_screen_size_cull_ratio;

		// Token: 0x04005C73 RID: 23667
		internal static int __PropertyOffset_platform_setting;

		// Token: 0x04005C74 RID: 23668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _platform_setting;

		// Token: 0x04005C75 RID: 23669
		internal static int __PropertyOffset_platform_min_lod;

		// Token: 0x04005C76 RID: 23670
		[Nullable(2)]
		private TArray<int> _platform_min_lod;

		// Token: 0x04005C77 RID: 23671
		internal static int __PropertyOffset_device_level_extra_lod_bias_platform;

		// Token: 0x04005C78 RID: 23672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _device_level_extra_lod_bias_platform;

		// Token: 0x04005C79 RID: 23673
		internal static int __PropertyOffset_device_level_extra_lod_bias;

		// Token: 0x04005C7A RID: 23674
		[Nullable(2)]
		private TArray<int> _device_level_extra_lod_bias;

		// Token: 0x04005C7B RID: 23675
		internal static int __PropertyOffset_device_level_extra_lod_bias_effected_level;

		// Token: 0x04005C7C RID: 23676
		[Nullable(2)]
		private TArray<int> _device_level_extra_lod_bias_effected_level;

		// Token: 0x04005C7D RID: 23677
		internal static int __PropertyOffset_extended_bound_sphere_radius;

		// Token: 0x04005C7E RID: 23678
		internal static int __PropertyOffset_screen_size_gradient;

		// Token: 0x04005C7F RID: 23679
		internal static int __PropertyOffset_use_kuro_lod_distance;

		// Token: 0x04005C80 RID: 23680
		internal static int __PropertyOffset_screen_size_pc;

		// Token: 0x04005C81 RID: 23681
		[Nullable(2)]
		private TArray<float> _screen_size_pc;

		// Token: 0x04005C82 RID: 23682
		internal static int __PropertyOffset_screen_size_pc_min;

		// Token: 0x04005C83 RID: 23683
		[Nullable(2)]
		private TArray<float> _screen_size_pc_min;

		// Token: 0x04005C84 RID: 23684
		internal static int __PropertyOffset_screen_size_mobile;

		// Token: 0x04005C85 RID: 23685
		[Nullable(2)]
		private TArray<float> _screen_size_mobile;

		// Token: 0x04005C86 RID: 23686
		internal static int __PropertyOffset_screen_size_mobile_min;

		// Token: 0x04005C87 RID: 23687
		[Nullable(2)]
		private TArray<float> _screen_size_mobile_min;

		// Token: 0x04005C88 RID: 23688
		internal static int __PropertyOffset_screen_size_cross_border_down_rate;

		// Token: 0x04005C89 RID: 23689
		internal static int __PropertyOffset_kuro_lod_distance_pc;

		// Token: 0x04005C8A RID: 23690
		[Nullable(2)]
		private TArray<float> _kuro_lod_distance_pc;

		// Token: 0x04005C8B RID: 23691
		internal static int __PropertyOffset_kuro_lod_distance_pc_max;

		// Token: 0x04005C8C RID: 23692
		[Nullable(2)]
		private TArray<float> _kuro_lod_distance_pc_max;

		// Token: 0x04005C8D RID: 23693
		internal static int __PropertyOffset_kuro_lod_distance_mobile;

		// Token: 0x04005C8E RID: 23694
		[Nullable(2)]
		private TArray<float> _kuro_lod_distance_mobile;

		// Token: 0x04005C8F RID: 23695
		internal static int __PropertyOffset_kuro_lod_distance_mobile_max;

		// Token: 0x04005C90 RID: 23696
		[Nullable(2)]
		private TArray<float> _kuro_lod_distance_mobile_max;

		// Token: 0x04005C91 RID: 23697
		internal static int __PropertyOffset_kuro_lod_distance_cross_border_scale_rate;

		// Token: 0x04005C92 RID: 23698
		internal static int __PropertyOffset_instance_count_score;

		// Token: 0x04005C93 RID: 23699
		internal static int __PropertyOffset_instance_type_count_score;

		// Token: 0x04005C94 RID: 23700
		internal static int __PropertyOffset_tags;

		// Token: 0x04005C95 RID: 23701
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _tags;

		// Token: 0x04005C96 RID: 23702
		internal static int __PropertyOffset_lod_mat_path;

		// Token: 0x04005C97 RID: 23703
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _lod_mat_path;

		// Token: 0x04005C98 RID: 23704
		internal static int __PropertyOffset_texture_count;

		// Token: 0x04005C99 RID: 23705
		internal static int __PropertyOffset_texture_count_mobile;

		// Token: 0x04005C9A RID: 23706
		internal static int __PropertyOffset_part_count;

		// Token: 0x04005C9B RID: 23707
		[Nullable(2)]
		private TArray<byte> _part_count;

		// Token: 0x04005C9C RID: 23708
		internal static int __PropertyOffset_uv_count;

		// Token: 0x04005C9D RID: 23709
		internal static int __PropertyOffset_lod_mat_num;

		// Token: 0x04005C9E RID: 23710
		internal static int __PropertyOffset_open_mobile_shadow;

		// Token: 0x04005C9F RID: 23711
		internal static int __PropertyOffset_can_override_mat_in_actor;

		// Token: 0x04005CA0 RID: 23712
		internal static byte __PropertyMask_can_override_mat_in_actor;

		// Token: 0x04005CA1 RID: 23713
		internal static int __PropertyOffset_is_open_far_shadow;

		// Token: 0x04005CA2 RID: 23714
		internal static byte __PropertyMask_is_open_far_shadow;

		// Token: 0x04005CA3 RID: 23715
		internal static int __PropertyOffset_is_open_vertex_compress;

		// Token: 0x04005CA4 RID: 23716
		internal static byte __PropertyMask_is_open_vertex_compress;

		// Token: 0x04005CA5 RID: 23717
		internal static int __PropertyOffset_ray_tracing_OMM;

		// Token: 0x04005CA6 RID: 23718
		internal static byte __PropertyMask_ray_tracing_OMM;

		// Token: 0x04005CA7 RID: 23719
		internal static int __PropertyOffset_can_be_hlod;

		// Token: 0x04005CA8 RID: 23720
		internal static byte __PropertyMask_can_be_hlod;

		// Token: 0x04005CA9 RID: 23721
		internal static int __PropertyOffset_mesh_distance_field;

		// Token: 0x04005CAA RID: 23722
		internal static byte __PropertyMask_mesh_distance_field;

		// Token: 0x04005CAB RID: 23723
		internal static int __PropertyOffset_desktop_maximal_triangle_density;

		// Token: 0x04005CAC RID: 23724
		internal static int __PropertyOffset_mobile_maximal_triangle_density;

		// Token: 0x04005CAD RID: 23725
		internal static int __PropertyOffset_max_allowed_mesh_reduction_percentage;

		// Token: 0x04005CAE RID: 23726
		internal static int __PropertyOffset_max_allowed_micro_triangle_percentage;

		// Token: 0x04005CAF RID: 23727
		internal static int __PropertyOffset_multiplatform_triangle_ratio;

		// Token: 0x04005CB0 RID: 23728
		[Nullable(2)]
		private TArray<float> _multiplatform_triangle_ratio;

		// Token: 0x04005CB1 RID: 23729
		internal static int __PropertyOffset_force_multiplatform_da_detect;
	}
}
