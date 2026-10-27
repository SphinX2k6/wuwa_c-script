using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000194 RID: 404
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_BlueprintBase")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UEnvQueryGenerator_BlueprintBase : UEnvQueryGenerator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001905 RID: 6405 RVA: 0x00024EE6 File Offset: 0x000230E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_BlueprintBase._ClassPtr;
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00024EF4 File Offset: 0x000230F4
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00024F2D File Offset: 0x0002312D
		[Nullable(1)]
		public unsafe FText GeneratorsActionDescription
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._GeneratorsActionDescription) == null)
				{
					result = (this._GeneratorsActionDescription = new FText(base.NativePtr + (IntPtr)UEnvQueryGenerator_BlueprintBase.__PropertyOffset_GeneratorsActionDescription, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UEnvQueryGenerator_BlueprintBase.__PropertyOffset_GeneratorsActionDescription)), value.NativePtr, 1);
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00024F48 File Offset: 0x00023148
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00024F5C File Offset: 0x0002315C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> Context
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_BlueprintBase.__PropertyOffset_Context);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_BlueprintBase.__PropertyOffset_Context) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00024F71 File Offset: 0x00023171
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00024F85 File Offset: 0x00023185
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryItemType> GeneratedItemType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_BlueprintBase.__PropertyOffset_GeneratedItemType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_BlueprintBase.__PropertyOffset_GeneratedItemType) = value;
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00024F9A File Offset: 0x0002319A
		[NullableContext(2)]
		public UObject GetQuerier()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UEnvQueryGenerator_BlueprintBase.__GetQuerier_Internal(base.NativePtr));
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00024FAC File Offset: 0x000231AC
		[NullableContext(2)]
		public virtual void DoItemGeneration(in TArray<FVector> ContextLocations)
		{
			UEnvQueryGenerator_BlueprintBase.__DoItemGeneration_Internal(base.NativePtr, (ContextLocations ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00024FC9 File Offset: 0x000231C9
		public void AddGeneratedVector(FVector GeneratedVector)
		{
			UEnvQueryGenerator_BlueprintBase.__AddGeneratedVector_Internal(base.NativePtr, GeneratedVector);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00024FD7 File Offset: 0x000231D7
		[NullableContext(2)]
		public void AddGeneratedActor(AActor GeneratedActor)
		{
			UEnvQueryGenerator_BlueprintBase.__AddGeneratedActor_Internal(base.NativePtr, (GeneratedActor != null) ? GeneratedActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001910 RID: 6416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetQuerier_Internal(IntPtr @this);

		// Token: 0x06001911 RID: 6417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoItemGeneration_Internal(IntPtr @this, IntPtr ContextLocations);

		// Token: 0x06001912 RID: 6418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddGeneratedVector_Internal(IntPtr @this, FVector GeneratedVector);

		// Token: 0x06001913 RID: 6419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddGeneratedActor_Internal(IntPtr @this, IntPtr GeneratedActor);

		// Token: 0x06001914 RID: 6420 RVA: 0x00024FF4 File Offset: 0x000231F4
		static UEnvQueryGenerator_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_BlueprintBase");
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00025004 File Offset: 0x00023204
		protected UEnvQueryGenerator_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0002502C File Offset: 0x0002322C
		protected UEnvQueryGenerator_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000719 RID: 1817
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_BlueprintBase";

		// Token: 0x0400071A RID: 1818
		private static IntPtr _ClassPtr;

		// Token: 0x0400071B RID: 1819
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400071C RID: 1820
		internal static int __PropertyOffset_GeneratorsActionDescription;

		// Token: 0x0400071D RID: 1821
		[Nullable(2)]
		private FText _GeneratorsActionDescription;

		// Token: 0x0400071E RID: 1822
		internal static int __PropertyOffset_Context;

		// Token: 0x0400071F RID: 1823
		internal static int __PropertyOffset_GeneratedItemType;

		// Token: 0x02002B67 RID: 11111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __DoItemGeneration_FunctionParams
		{
			// Token: 0x040163EB RID: 91115
			[FieldOffset(0)]
			public byte ContextLocations;
		}
	}
}
