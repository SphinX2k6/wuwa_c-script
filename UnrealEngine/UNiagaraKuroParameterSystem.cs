using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C14 RID: 7188
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraKuroParameterSystem")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UNiagaraKuroParameterSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BBA7 RID: 113575 RVA: 0x0028CDFA File Offset: 0x0028AFFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraKuroParameterSystem._ClassPtr;
		}

		// Token: 0x0601BBA8 RID: 113576 RVA: 0x0028CE08 File Offset: 0x0028B008
		public UNiagaraKuroParameterSystem() : this(BuiltinUtils.AllocNativeUObject(UNiagaraKuroParameterSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BBA9 RID: 113577 RVA: 0x0028CE30 File Offset: 0x0028B030
		[NullableContext(1)]
		public UNiagaraKuroParameterSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraKuroParameterSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601BBAA RID: 113578 RVA: 0x0028CE63 File Offset: 0x0028B063
		public void SetParameterVector(FName Collection, FName Name, in FVector Val)
		{
			UNiagaraKuroParameterSystem.__SetParameterVector_Internal(base.NativePtr, Collection, Name, Val);
		}

		// Token: 0x0601BBAB RID: 113579 RVA: 0x0028CE73 File Offset: 0x0028B073
		public void SetParameterLinearColor(FName Collection, FName Name, in FLinearColor Val)
		{
			UNiagaraKuroParameterSystem.__SetParameterLinearColor_Internal(base.NativePtr, Collection, Name, Val);
		}

		// Token: 0x0601BBAC RID: 113580 RVA: 0x0028CE83 File Offset: 0x0028B083
		public void SetParameterFloat(FName Collection, FName Name, float Val)
		{
			UNiagaraKuroParameterSystem.__SetParameterFloat_Internal(base.NativePtr, Collection, Name, Val);
		}

		// Token: 0x0601BBAD RID: 113581 RVA: 0x0028CE93 File Offset: 0x0028B093
		public void RemoveParameterVector(FName Collection, FName Name)
		{
			UNiagaraKuroParameterSystem.__RemoveParameterVector_Internal(base.NativePtr, Collection, Name);
		}

		// Token: 0x0601BBAE RID: 113582 RVA: 0x0028CEA2 File Offset: 0x0028B0A2
		public void RemoveParameterLinearColor(FName Collection, FName Name)
		{
			UNiagaraKuroParameterSystem.__RemoveParameterLinearColor_Internal(base.NativePtr, Collection, Name);
		}

		// Token: 0x0601BBAF RID: 113583 RVA: 0x0028CEB1 File Offset: 0x0028B0B1
		public void RemoveParameterFloat(FName Collection, FName Name)
		{
			UNiagaraKuroParameterSystem.__RemoveParameterFloat_Internal(base.NativePtr, Collection, Name);
		}

		// Token: 0x0601BBB0 RID: 113584 RVA: 0x0028CEC0 File Offset: 0x0028B0C0
		public void RemoveCollection(FName Collection)
		{
			UNiagaraKuroParameterSystem.__RemoveCollection_Internal(base.NativePtr, Collection);
		}

		// Token: 0x0601BBB1 RID: 113585 RVA: 0x0028CECE File Offset: 0x0028B0CE
		public FVector GetParameterVector(FName Collection, FName Name, in FVector Default)
		{
			return UNiagaraKuroParameterSystem.__GetParameterVector_Internal(base.NativePtr, Collection, Name, Default);
		}

		// Token: 0x0601BBB2 RID: 113586 RVA: 0x0028CEDE File Offset: 0x0028B0DE
		public FLinearColor GetParameterLinearColor(FName Collection, FName Name, in FLinearColor Default)
		{
			return UNiagaraKuroParameterSystem.__GetParameterLinearColor_Internal(base.NativePtr, Collection, Name, Default);
		}

		// Token: 0x0601BBB3 RID: 113587 RVA: 0x0028CEEE File Offset: 0x0028B0EE
		public float GetParameterFloat(FName Collection, FName Name, float Default)
		{
			return UNiagaraKuroParameterSystem.__GetParameterFloat_Internal(base.NativePtr, Collection, Name, Default);
		}

		// Token: 0x0601BBB4 RID: 113588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterVector_Internal(IntPtr @this, FName Collection, FName Name, in FVector Val);

		// Token: 0x0601BBB5 RID: 113589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterLinearColor_Internal(IntPtr @this, FName Collection, FName Name, in FLinearColor Val);

		// Token: 0x0601BBB6 RID: 113590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterFloat_Internal(IntPtr @this, FName Collection, FName Name, float Val);

		// Token: 0x0601BBB7 RID: 113591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveParameterVector_Internal(IntPtr @this, FName Collection, FName Name);

		// Token: 0x0601BBB8 RID: 113592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveParameterLinearColor_Internal(IntPtr @this, FName Collection, FName Name);

		// Token: 0x0601BBB9 RID: 113593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveParameterFloat_Internal(IntPtr @this, FName Collection, FName Name);

		// Token: 0x0601BBBA RID: 113594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveCollection_Internal(IntPtr @this, FName Collection);

		// Token: 0x0601BBBB RID: 113595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetParameterVector_Internal(IntPtr @this, FName Collection, FName Name, in FVector Default);

		// Token: 0x0601BBBC RID: 113596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetParameterLinearColor_Internal(IntPtr @this, FName Collection, FName Name, in FLinearColor Default);

		// Token: 0x0601BBBD RID: 113597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetParameterFloat_Internal(IntPtr @this, FName Collection, FName Name, float Default);

		// Token: 0x0601BBBE RID: 113598 RVA: 0x0028CEFE File Offset: 0x0028B0FE
		static UNiagaraKuroParameterSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.NiagaraKuroParameterSystem");
		}

		// Token: 0x0601BBBF RID: 113599 RVA: 0x0028CF0C File Offset: 0x0028B10C
		protected UNiagaraKuroParameterSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE8D RID: 61069
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraKuroParameterSystem";

		// Token: 0x0400EE8E RID: 61070
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE8F RID: 61071
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
