using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F67 RID: 8039
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.GrassInput")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FGrassInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E7B5 RID: 124853 RVA: 0x002D4E7F File Offset: 0x002D307F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGrassInput._ScriptStructPtr != 0) ? FGrassInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.GrassInput", ref FGrassInput._ScriptStructPtr);
		}

		// Token: 0x1700792F RID: 31023
		// (get) Token: 0x0601E7B6 RID: 124854 RVA: 0x002D4EA3 File Offset: 0x002D30A3
		// (set) Token: 0x0601E7B7 RID: 124855 RVA: 0x002D4EB7 File Offset: 0x002D30B7
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassInput.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassInput.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17007930 RID: 31024
		// (get) Token: 0x0601E7B8 RID: 124856 RVA: 0x002D4ECC File Offset: 0x002D30CC
		// (set) Token: 0x0601E7B9 RID: 124857 RVA: 0x002D4EE0 File Offset: 0x002D30E0
		[Nullable(2)]
		public unsafe ULandscapeGrassType GrassType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeGrassType>(base.NativePtr / (IntPtr)sizeof(void*) + FGrassInput.__PropertyOffset_GrassType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGrassInput.__PropertyOffset_GrassType, value);
			}
		}

		// Token: 0x17007931 RID: 31025
		// (get) Token: 0x0601E7BA RID: 124858 RVA: 0x002D4EF8 File Offset: 0x002D30F8
		// (set) Token: 0x0601E7BB RID: 124859 RVA: 0x002D4F3B File Offset: 0x002D313B
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)FGrassInput.__PropertyOffset_Input, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)FGrassInput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E7BC RID: 124860 RVA: 0x002D4F5C File Offset: 0x002D315C
		public FGrassInput()
		{
		}

		// Token: 0x0601E7BD RID: 124861 RVA: 0x002D4F64 File Offset: 0x002D3164
		public FGrassInput(FName Name, ULandscapeGrassType GrassType, FExpressionInput Input)
		{
			this.Name = Name;
			this.GrassType = GrassType;
			this.Input = Input;
		}

		// Token: 0x0601E7BE RID: 124862 RVA: 0x002D4F81 File Offset: 0x002D3181
		protected override IntPtr GetUStructPtr()
		{
			return FGrassInput.StaticStruct();
		}

		// Token: 0x0601E7BF RID: 124863 RVA: 0x002D4F8D File Offset: 0x002D318D
		[NullableContext(2)]
		public FGrassInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E7C0 RID: 124864 RVA: 0x002D4F97 File Offset: 0x002D3197
		public FGrassInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E7C1 RID: 124865 RVA: 0x002D4FA2 File Offset: 0x002D31A2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGrassInput(Pointer, false, true);
		}

		// Token: 0x0601E7C2 RID: 124866 RVA: 0x002D4FAC File Offset: 0x002D31AC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGrassInput(Pointer, MemoryOwner);
		}

		// Token: 0x04010793 RID: 67475
		public const string __ObjectPath = "/Script/Landscape.GrassInput";

		// Token: 0x04010794 RID: 67476
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010795 RID: 67477
		internal static int __PropertyOffset_Name;

		// Token: 0x04010796 RID: 67478
		internal static int __PropertyOffset_GrassType;

		// Token: 0x04010797 RID: 67479
		internal static int __PropertyOffset_Input;

		// Token: 0x04010798 RID: 67480
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
