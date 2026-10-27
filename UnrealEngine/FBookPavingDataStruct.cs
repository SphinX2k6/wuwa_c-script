using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A51 RID: 6737
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.BookPavingDataStruct")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FBookPavingDataStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018E4F RID: 101967 RVA: 0x0024CE12 File Offset: 0x0024B012
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBookPavingDataStruct._ScriptStructPtr != 0) ? FBookPavingDataStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.BookPavingDataStruct", ref FBookPavingDataStruct._ScriptStructPtr);
		}

		// Token: 0x17006288 RID: 25224
		// (get) Token: 0x06018E50 RID: 101968 RVA: 0x0024CE36 File Offset: 0x0024B036
		// (set) Token: 0x06018E51 RID: 101969 RVA: 0x0024CE4A File Offset: 0x0024B04A
		[Nullable(2)]
		public unsafe UStaticMeshComponent MeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FBookPavingDataStruct.__PropertyOffset_MeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBookPavingDataStruct.__PropertyOffset_MeshComponent, value);
			}
		}

		// Token: 0x17006289 RID: 25225
		// (get) Token: 0x06018E52 RID: 101970 RVA: 0x0024CE5F File Offset: 0x0024B05F
		// (set) Token: 0x06018E53 RID: 101971 RVA: 0x0024CE73 File Offset: 0x0024B073
		public unsafe FTransformDouble TransformOld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_TransformOld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_TransformOld) = value;
			}
		}

		// Token: 0x1700628A RID: 25226
		// (get) Token: 0x06018E54 RID: 101972 RVA: 0x0024CE88 File Offset: 0x0024B088
		// (set) Token: 0x06018E55 RID: 101973 RVA: 0x0024CE9C File Offset: 0x0024B09C
		public unsafe FTransformDouble TransformNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_TransformNew);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_TransformNew) = value;
			}
		}

		// Token: 0x1700628B RID: 25227
		// (get) Token: 0x06018E56 RID: 101974 RVA: 0x0024CEB1 File Offset: 0x0024B0B1
		// (set) Token: 0x06018E57 RID: 101975 RVA: 0x0024CEC1 File Offset: 0x0024B0C1
		public unsafe bool PageTurning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_PageTurning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_PageTurning) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700628C RID: 25228
		// (get) Token: 0x06018E58 RID: 101976 RVA: 0x0024CED2 File Offset: 0x0024B0D2
		// (set) Token: 0x06018E59 RID: 101977 RVA: 0x0024CEE2 File Offset: 0x0024B0E2
		public unsafe int Tick_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_Tick_Add);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_Tick_Add) = value;
			}
		}

		// Token: 0x1700628D RID: 25229
		// (get) Token: 0x06018E5A RID: 101978 RVA: 0x0024CEF3 File Offset: 0x0024B0F3
		// (set) Token: 0x06018E5B RID: 101979 RVA: 0x0024CF03 File Offset: 0x0024B103
		public unsafe float DeltaSeconds_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_DeltaSeconds_Add);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_DeltaSeconds_Add) = value;
			}
		}

		// Token: 0x1700628E RID: 25230
		// (get) Token: 0x06018E5C RID: 101980 RVA: 0x0024CF14 File Offset: 0x0024B114
		// (set) Token: 0x06018E5D RID: 101981 RVA: 0x0024CF24 File Offset: 0x0024B124
		public unsafe bool PavingState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_PavingState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_PavingState) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700628F RID: 25231
		// (get) Token: 0x06018E5E RID: 101982 RVA: 0x0024CF38 File Offset: 0x0024B138
		// (set) Token: 0x06018E5F RID: 101983 RVA: 0x0024CF7B File Offset: 0x0024B17B
		public TArray<float> PageTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PageTimes) == null)
				{
					result = (this._PageTimes = new TArray<float>(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_PageTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PageTimes.CopyAssign(value);
			}
		}

		// Token: 0x17006290 RID: 25232
		// (get) Token: 0x06018E60 RID: 101984 RVA: 0x0024CF89 File Offset: 0x0024B189
		// (set) Token: 0x06018E61 RID: 101985 RVA: 0x0024CF99 File Offset: 0x0024B199
		public unsafe float PavingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_PavingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_PavingTime) = value;
			}
		}

		// Token: 0x17006291 RID: 25233
		// (get) Token: 0x06018E62 RID: 101986 RVA: 0x0024CFAA File Offset: 0x0024B1AA
		// (set) Token: 0x06018E63 RID: 101987 RVA: 0x0024CFBA File Offset: 0x0024B1BA
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBookPavingDataStruct.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x06018E64 RID: 101988 RVA: 0x0024CFCB File Offset: 0x0024B1CB
		public FBookPavingDataStruct()
		{
		}

		// Token: 0x06018E65 RID: 101989 RVA: 0x0024CFD4 File Offset: 0x0024B1D4
		public FBookPavingDataStruct(UStaticMeshComponent MeshComponent, FTransformDouble TransformOld, FTransformDouble TransformNew, bool PageTurning, int Tick_Add, float DeltaSeconds_Add, bool PavingState, TArray<float> PageTimes, float PavingTime, float Speed)
		{
			this.MeshComponent = MeshComponent;
			this.TransformOld = TransformOld;
			this.TransformNew = TransformNew;
			this.PageTurning = PageTurning;
			this.Tick_Add = Tick_Add;
			this.DeltaSeconds_Add = DeltaSeconds_Add;
			this.PavingState = PavingState;
			this.PageTimes = PageTimes;
			this.PavingTime = PavingTime;
			this.Speed = Speed;
		}

		// Token: 0x06018E66 RID: 101990 RVA: 0x0024D034 File Offset: 0x0024B234
		protected override IntPtr GetUStructPtr()
		{
			return FBookPavingDataStruct.StaticStruct();
		}

		// Token: 0x06018E67 RID: 101991 RVA: 0x0024D040 File Offset: 0x0024B240
		[NullableContext(2)]
		public FBookPavingDataStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018E68 RID: 101992 RVA: 0x0024D04A File Offset: 0x0024B24A
		public FBookPavingDataStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018E69 RID: 101993 RVA: 0x0024D055 File Offset: 0x0024B255
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBookPavingDataStruct(Pointer, false, true);
		}

		// Token: 0x06018E6A RID: 101994 RVA: 0x0024D05F File Offset: 0x0024B25F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBookPavingDataStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400D781 RID: 55169
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.BookPavingDataStruct";

		// Token: 0x0400D782 RID: 55170
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D783 RID: 55171
		internal static int __PropertyOffset_MeshComponent;

		// Token: 0x0400D784 RID: 55172
		internal static int __PropertyOffset_TransformOld;

		// Token: 0x0400D785 RID: 55173
		internal static int __PropertyOffset_TransformNew;

		// Token: 0x0400D786 RID: 55174
		internal static int __PropertyOffset_PageTurning;

		// Token: 0x0400D787 RID: 55175
		internal static int __PropertyOffset_Tick_Add;

		// Token: 0x0400D788 RID: 55176
		internal static int __PropertyOffset_DeltaSeconds_Add;

		// Token: 0x0400D789 RID: 55177
		internal static int __PropertyOffset_PavingState;

		// Token: 0x0400D78A RID: 55178
		internal static int __PropertyOffset_PageTimes;

		// Token: 0x0400D78B RID: 55179
		[Nullable(2)]
		private TArray<float> _PageTimes;

		// Token: 0x0400D78C RID: 55180
		internal static int __PropertyOffset_PavingTime;

		// Token: 0x0400D78D RID: 55181
		internal static int __PropertyOffset_Speed;
	}
}
