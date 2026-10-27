using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002026 RID: 8230
	[UnrealObjectPath("/Script/LGUI.LGUIBehaviourArrayContainer")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLGUIBehaviourArrayContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F036 RID: 127030 RVA: 0x002E1AC9 File Offset: 0x002DFCC9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIBehaviourArrayContainer._ScriptStructPtr != 0) ? FLGUIBehaviourArrayContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIBehaviourArrayContainer", ref FLGUIBehaviourArrayContainer._ScriptStructPtr);
		}

		// Token: 0x17007B5F RID: 31583
		// (get) Token: 0x0601F037 RID: 127031 RVA: 0x002E1AF0 File Offset: 0x002DFCF0
		// (set) Token: 0x0601F038 RID: 127032 RVA: 0x002E1B33 File Offset: 0x002DFD33
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<ULGUIBehaviour>> LGUIBehaviourArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<ULGUIBehaviour>> result;
				if ((result = this._LGUIBehaviourArray) == null)
				{
					result = (this._LGUIBehaviourArray = new TArray<TWeakObjectPtr<ULGUIBehaviour>>(base.NativePtr + (IntPtr)FLGUIBehaviourArrayContainer.__PropertyOffset_LGUIBehaviourArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.LGUIBehaviourArray.CopyAssign(value);
			}
		}

		// Token: 0x0601F039 RID: 127033 RVA: 0x002E1B41 File Offset: 0x002DFD41
		public FLGUIBehaviourArrayContainer()
		{
		}

		// Token: 0x0601F03A RID: 127034 RVA: 0x002E1B49 File Offset: 0x002DFD49
		public FLGUIBehaviourArrayContainer([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<ULGUIBehaviour>> LGUIBehaviourArray)
		{
			this.LGUIBehaviourArray = LGUIBehaviourArray;
		}

		// Token: 0x0601F03B RID: 127035 RVA: 0x002E1B58 File Offset: 0x002DFD58
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIBehaviourArrayContainer.StaticStruct();
		}

		// Token: 0x0601F03C RID: 127036 RVA: 0x002E1B64 File Offset: 0x002DFD64
		[NullableContext(2)]
		public FLGUIBehaviourArrayContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F03D RID: 127037 RVA: 0x002E1B6E File Offset: 0x002DFD6E
		public FLGUIBehaviourArrayContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F03E RID: 127038 RVA: 0x002E1B79 File Offset: 0x002DFD79
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIBehaviourArrayContainer(Pointer, false, true);
		}

		// Token: 0x0601F03F RID: 127039 RVA: 0x002E1B83 File Offset: 0x002DFD83
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIBehaviourArrayContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04010D9E RID: 69022
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIBehaviourArrayContainer";

		// Token: 0x04010D9F RID: 69023
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010DA0 RID: 69024
		internal static int __PropertyOffset_LGUIBehaviourArray;

		// Token: 0x04010DA1 RID: 69025
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<ULGUIBehaviour>> _LGUIBehaviourArray;
	}
}
