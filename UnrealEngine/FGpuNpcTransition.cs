using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001757 RID: 5975
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.GpuNpcTransition")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FGpuNpcTransition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601578A RID: 87946 RVA: 0x001F8D2B File Offset: 0x001F6F2B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGpuNpcTransition._ScriptStructPtr != 0) ? FGpuNpcTransition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.GpuNpcTransition", ref FGpuNpcTransition._ScriptStructPtr);
		}

		// Token: 0x170054C5 RID: 21701
		// (get) Token: 0x0601578B RID: 87947 RVA: 0x001F8D50 File Offset: 0x001F6F50
		// (set) Token: 0x0601578C RID: 87948 RVA: 0x001F8D93 File Offset: 0x001F6F93
		public TMap<int, int> Transitions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._Transitions) == null)
				{
					result = (this._Transitions = new TMap<int, int>(base.NativePtr + (IntPtr)FGpuNpcTransition.__PropertyOffset_Transitions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transitions.CopyAssign(value);
			}
		}

		// Token: 0x0601578D RID: 87949 RVA: 0x001F8DA1 File Offset: 0x001F6FA1
		public FGpuNpcTransition()
		{
		}

		// Token: 0x0601578E RID: 87950 RVA: 0x001F8DA9 File Offset: 0x001F6FA9
		public FGpuNpcTransition(TMap<int, int> Transitions)
		{
			this.Transitions = Transitions;
		}

		// Token: 0x0601578F RID: 87951 RVA: 0x001F8DB8 File Offset: 0x001F6FB8
		protected override IntPtr GetUStructPtr()
		{
			return FGpuNpcTransition.StaticStruct();
		}

		// Token: 0x06015790 RID: 87952 RVA: 0x001F8DC4 File Offset: 0x001F6FC4
		[NullableContext(2)]
		public FGpuNpcTransition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015791 RID: 87953 RVA: 0x001F8DCE File Offset: 0x001F6FCE
		public FGpuNpcTransition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015792 RID: 87954 RVA: 0x001F8DD9 File Offset: 0x001F6FD9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGpuNpcTransition(Pointer, false, true);
		}

		// Token: 0x06015793 RID: 87955 RVA: 0x001F8DE3 File Offset: 0x001F6FE3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGpuNpcTransition(Pointer, MemoryOwner);
		}

		// Token: 0x0400BB6C RID: 47980
		public const string __ObjectPath = "/Script/KuroComponent.GpuNpcTransition";

		// Token: 0x0400BB6D RID: 47981
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BB6E RID: 47982
		internal static int __PropertyOffset_Transitions;

		// Token: 0x0400BB6F RID: 47983
		[Nullable(2)]
		private TMap<int, int> _Transitions;
	}
}
