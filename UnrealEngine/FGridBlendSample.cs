using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C13 RID: 3091
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GridBlendSample")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FGridBlendSample : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009C43 RID: 40003 RVA: 0x000DE312 File Offset: 0x000DC512
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGridBlendSample._ScriptStructPtr != 0) ? FGridBlendSample._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GridBlendSample", ref FGridBlendSample._ScriptStructPtr);
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x06009C44 RID: 40004 RVA: 0x000DE338 File Offset: 0x000DC538
		// (set) Token: 0x06009C45 RID: 40005 RVA: 0x000DE37B File Offset: 0x000DC57B
		public FEditorElement GridElement
		{
			get
			{
				base.FastCheckIsValid();
				FEditorElement result;
				if ((result = this._GridElement) == null)
				{
					result = (this._GridElement = new FEditorElement(base.NativePtr + (IntPtr)FGridBlendSample.__PropertyOffset_GridElement, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorElement.StaticStruct(), base.NativePtr + (IntPtr)FGridBlendSample.__PropertyOffset_GridElement, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x06009C46 RID: 40006 RVA: 0x000DE39C File Offset: 0x000DC59C
		// (set) Token: 0x06009C47 RID: 40007 RVA: 0x000DE3AC File Offset: 0x000DC5AC
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGridBlendSample.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGridBlendSample.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x000DE3BD File Offset: 0x000DC5BD
		public FGridBlendSample()
		{
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x000DE3C5 File Offset: 0x000DC5C5
		public FGridBlendSample(FEditorElement GridElement, float BlendWeight)
		{
			this.GridElement = GridElement;
			this.BlendWeight = BlendWeight;
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x000DE3DB File Offset: 0x000DC5DB
		protected override IntPtr GetUStructPtr()
		{
			return FGridBlendSample.StaticStruct();
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x000DE3E7 File Offset: 0x000DC5E7
		[NullableContext(2)]
		public FGridBlendSample(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x000DE3F1 File Offset: 0x000DC5F1
		public FGridBlendSample(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x000DE3FC File Offset: 0x000DC5FC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGridBlendSample(Pointer, false, true);
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x000DE406 File Offset: 0x000DC606
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGridBlendSample(Pointer, MemoryOwner);
		}

		// Token: 0x04005640 RID: 22080
		public const string __ObjectPath = "/Script/Engine.GridBlendSample";

		// Token: 0x04005641 RID: 22081
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005642 RID: 22082
		internal static int __PropertyOffset_GridElement;

		// Token: 0x04005643 RID: 22083
		[Nullable(2)]
		private FEditorElement _GridElement;

		// Token: 0x04005644 RID: 22084
		internal static int __PropertyOffset_BlendWeight;
	}
}
