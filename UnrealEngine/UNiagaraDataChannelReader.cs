using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002553 RID: 9555
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelReader")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNiagaraDataChannelReader : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237EB RID: 145387 RVA: 0x00347989 File Offset: 0x00345B89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelReader._ClassPtr;
		}

		// Token: 0x060237EC RID: 145388 RVA: 0x00347998 File Offset: 0x00345B98
		public UNiagaraDataChannelReader() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelReader.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237ED RID: 145389 RVA: 0x003479C0 File Offset: 0x00345BC0
		public UNiagaraDataChannelReader(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelReader.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700884C RID: 34892
		// (get) Token: 0x060237EE RID: 145390 RVA: 0x003479F3 File Offset: 0x00345BF3
		// (set) Token: 0x060237EF RID: 145391 RVA: 0x00347A07 File Offset: 0x00345C07
		[Nullable(2)]
		public unsafe UNiagaraDataChannelHandler Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelReader.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelReader.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x060237F0 RID: 145392 RVA: 0x00347A1C File Offset: 0x00345C1C
		public unsafe FVector4 ReadVector4(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadVector4_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237F1 RID: 145393 RVA: 0x00347A3C File Offset: 0x00345C3C
		public unsafe FVector2D ReadVector2D(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadVector2D_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237F2 RID: 145394 RVA: 0x00347A5C File Offset: 0x00345C5C
		public unsafe FVector ReadVector(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadVector_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237F3 RID: 145395 RVA: 0x00347A7C File Offset: 0x00345C7C
		public unsafe FNiagaraSpawnInfo ReadSpawnInfo(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return new FNiagaraSpawnInfo(UNiagaraDataChannelReader.__ReadSpawnInfo_Internal(base.NativePtr, VarName, Index, ref IsValid), null);
			}
		}

		// Token: 0x060237F4 RID: 145396 RVA: 0x00347AA4 File Offset: 0x00345CA4
		public unsafe FQuat ReadQuat(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadQuat_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237F5 RID: 145397 RVA: 0x00347AC4 File Offset: 0x00345CC4
		public unsafe FVector ReadPosition(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadPosition_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237F6 RID: 145398 RVA: 0x00347AE4 File Offset: 0x00345CE4
		public unsafe FLinearColor ReadLinearColor(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadLinearColor_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237F7 RID: 145399 RVA: 0x00347B04 File Offset: 0x00345D04
		public unsafe int ReadInt(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadInt_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237F8 RID: 145400 RVA: 0x00347B24 File Offset: 0x00345D24
		public unsafe FNiagaraID ReadID(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return new FNiagaraID(UNiagaraDataChannelReader.__ReadID_Internal(base.NativePtr, VarName, Index, ref IsValid), null);
			}
		}

		// Token: 0x060237F9 RID: 145401 RVA: 0x00347B4C File Offset: 0x00345D4C
		public unsafe double ReadFloat(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadFloat_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237FA RID: 145402 RVA: 0x00347B6C File Offset: 0x00345D6C
		public unsafe byte ReadEnum(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadEnum_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237FB RID: 145403 RVA: 0x00347B8C File Offset: 0x00345D8C
		public unsafe bool ReadBool(FName VarName, int Index, ref bool IsValid)
		{
			fixed (bool* ptr = &IsValid)
			{
				void* ptr2 = (void*)ptr;
				return UNiagaraDataChannelReader.__ReadBool_Internal(base.NativePtr, VarName, Index, ref IsValid);
			}
		}

		// Token: 0x060237FC RID: 145404 RVA: 0x00347BAC File Offset: 0x00345DAC
		public int Num()
		{
			return UNiagaraDataChannelReader.__Num_Internal(base.NativePtr);
		}

		// Token: 0x060237FD RID: 145405 RVA: 0x00347BB9 File Offset: 0x00345DB9
		[NullableContext(2)]
		public bool InitAccess(FNiagaraDataChannelSearchParameters SearchParams, bool bReadPrevFrameData)
		{
			return UNiagaraDataChannelReader.__InitAccess_Internal(base.NativePtr, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, bReadPrevFrameData);
		}

		// Token: 0x060237FE RID: 145406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __ReadVector4_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x060237FF RID: 145407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __ReadVector2D_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023800 RID: 145408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ReadVector_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023801 RID: 145409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ReadSpawnInfo_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023802 RID: 145410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __ReadQuat_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023803 RID: 145411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ReadPosition_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023804 RID: 145412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __ReadLinearColor_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023805 RID: 145413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ReadInt_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023806 RID: 145414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ReadID_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023807 RID: 145415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __ReadFloat_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023808 RID: 145416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __ReadEnum_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x06023809 RID: 145417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReadBool_Internal(IntPtr @this, FName VarName, int Index, ref bool IsValid);

		// Token: 0x0602380A RID: 145418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Num_Internal(IntPtr @this);

		// Token: 0x0602380B RID: 145419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitAccess_Internal(IntPtr @this, IntPtr SearchParams, bool bReadPrevFrameData);

		// Token: 0x0602380C RID: 145420 RVA: 0x00347BD6 File Offset: 0x00345DD6
		static UNiagaraDataChannelReader()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelReader");
		}

		// Token: 0x0602380D RID: 145421 RVA: 0x00347BE4 File Offset: 0x00345DE4
		protected UNiagaraDataChannelReader(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013086 RID: 77958
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelReader";

		// Token: 0x04013087 RID: 77959
		private static IntPtr _ClassPtr;

		// Token: 0x04013088 RID: 77960
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013089 RID: 77961
		internal static int __PropertyOffset_Owner;
	}
}
