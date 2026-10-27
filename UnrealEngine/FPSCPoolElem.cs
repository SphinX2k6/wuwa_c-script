using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001043 RID: 4163
	[UnrealObjectPath("/Script/Engine.PSCPoolElem")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPSCPoolElem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ECE8 RID: 60648 RVA: 0x0015F6AE File Offset: 0x0015D8AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSCPoolElem._ScriptStructPtr != 0) ? FPSCPoolElem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSCPoolElem", ref FPSCPoolElem._ScriptStructPtr);
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600ECE9 RID: 60649 RVA: 0x0015F6D2 File Offset: 0x0015D8D2
		// (set) Token: 0x0600ECEA RID: 60650 RVA: 0x0015F6E6 File Offset: 0x0015D8E6
		[Nullable(2)]
		public unsafe UParticleSystemComponent PSC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FPSCPoolElem.__PropertyOffset_PSC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPSCPoolElem.__PropertyOffset_PSC, value);
			}
		}

		// Token: 0x0600ECEB RID: 60651 RVA: 0x0015F6FB File Offset: 0x0015D8FB
		public FPSCPoolElem()
		{
		}

		// Token: 0x0600ECEC RID: 60652 RVA: 0x0015F703 File Offset: 0x0015D903
		[NullableContext(1)]
		public FPSCPoolElem(UParticleSystemComponent PSC)
		{
			this.PSC = PSC;
		}

		// Token: 0x0600ECED RID: 60653 RVA: 0x0015F712 File Offset: 0x0015D912
		protected override IntPtr GetUStructPtr()
		{
			return FPSCPoolElem.StaticStruct();
		}

		// Token: 0x0600ECEE RID: 60654 RVA: 0x0015F71E File Offset: 0x0015D91E
		[NullableContext(2)]
		public FPSCPoolElem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ECEF RID: 60655 RVA: 0x0015F728 File Offset: 0x0015D928
		public FPSCPoolElem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ECF0 RID: 60656 RVA: 0x0015F733 File Offset: 0x0015D933
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSCPoolElem(Pointer, false, true);
		}

		// Token: 0x0600ECF1 RID: 60657 RVA: 0x0015F73D File Offset: 0x0015D93D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSCPoolElem(Pointer, MemoryOwner);
		}

		// Token: 0x04008045 RID: 32837
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PSCPoolElem";

		// Token: 0x04008046 RID: 32838
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008047 RID: 32839
		internal static int __PropertyOffset_PSC;
	}
}
