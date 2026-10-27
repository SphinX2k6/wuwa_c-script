using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002532 RID: 9522
	[UnrealObjectPath("/Script/Niagara.NCPoolElement")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNCPoolElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023598 RID: 144792 RVA: 0x0034484E File Offset: 0x00342A4E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNCPoolElement._ScriptStructPtr != 0) ? FNCPoolElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NCPoolElement", ref FNCPoolElement._ScriptStructPtr);
		}

		// Token: 0x170087E6 RID: 34790
		// (get) Token: 0x06023599 RID: 144793 RVA: 0x00344872 File Offset: 0x00342A72
		// (set) Token: 0x0602359A RID: 144794 RVA: 0x00344886 File Offset: 0x00342A86
		[Nullable(2)]
		public unsafe UNiagaraComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FNCPoolElement.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNCPoolElement.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x0602359B RID: 144795 RVA: 0x0034489B File Offset: 0x00342A9B
		public FNCPoolElement()
		{
		}

		// Token: 0x0602359C RID: 144796 RVA: 0x003448A3 File Offset: 0x00342AA3
		[NullableContext(1)]
		public FNCPoolElement(UNiagaraComponent Component)
		{
			this.Component = Component;
		}

		// Token: 0x0602359D RID: 144797 RVA: 0x003448B2 File Offset: 0x00342AB2
		protected override IntPtr GetUStructPtr()
		{
			return FNCPoolElement.StaticStruct();
		}

		// Token: 0x0602359E RID: 144798 RVA: 0x003448BE File Offset: 0x00342ABE
		[NullableContext(2)]
		public FNCPoolElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602359F RID: 144799 RVA: 0x003448C8 File Offset: 0x00342AC8
		public FNCPoolElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060235A0 RID: 144800 RVA: 0x003448D3 File Offset: 0x00342AD3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNCPoolElement(Pointer, false, true);
		}

		// Token: 0x060235A1 RID: 144801 RVA: 0x003448DD File Offset: 0x00342ADD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNCPoolElement(Pointer, MemoryOwner);
		}

		// Token: 0x04012F9E RID: 77726
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NCPoolElement";

		// Token: 0x04012F9F RID: 77727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FA0 RID: 77728
		internal static int __PropertyOffset_Component;
	}
}
