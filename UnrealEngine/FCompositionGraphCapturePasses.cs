using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002301 RID: 8961
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneCapture.CompositionGraphCapturePasses")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCompositionGraphCapturePasses : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021F46 RID: 139078 RVA: 0x0032366C File Offset: 0x0032186C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompositionGraphCapturePasses._ScriptStructPtr != 0) ? FCompositionGraphCapturePasses._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneCapture.CompositionGraphCapturePasses", ref FCompositionGraphCapturePasses._ScriptStructPtr);
		}

		// Token: 0x1700833D RID: 33597
		// (get) Token: 0x06021F47 RID: 139079 RVA: 0x00323690 File Offset: 0x00321890
		// (set) Token: 0x06021F48 RID: 139080 RVA: 0x003236D3 File Offset: 0x003218D3
		public TArray<string> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<string>(base.NativePtr + (IntPtr)FCompositionGraphCapturePasses.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x06021F49 RID: 139081 RVA: 0x003236E1 File Offset: 0x003218E1
		public FCompositionGraphCapturePasses()
		{
		}

		// Token: 0x06021F4A RID: 139082 RVA: 0x003236E9 File Offset: 0x003218E9
		public FCompositionGraphCapturePasses(TArray<string> Value)
		{
			this.Value = Value;
		}

		// Token: 0x06021F4B RID: 139083 RVA: 0x003236F8 File Offset: 0x003218F8
		protected override IntPtr GetUStructPtr()
		{
			return FCompositionGraphCapturePasses.StaticStruct();
		}

		// Token: 0x06021F4C RID: 139084 RVA: 0x00323704 File Offset: 0x00321904
		[NullableContext(2)]
		public FCompositionGraphCapturePasses(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F4D RID: 139085 RVA: 0x0032370E File Offset: 0x0032190E
		public FCompositionGraphCapturePasses(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F4E RID: 139086 RVA: 0x00323719 File Offset: 0x00321919
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompositionGraphCapturePasses(Pointer, false, true);
		}

		// Token: 0x06021F4F RID: 139087 RVA: 0x00323723 File Offset: 0x00321923
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompositionGraphCapturePasses(Pointer, MemoryOwner);
		}

		// Token: 0x040121C1 RID: 74177
		public const string __ObjectPath = "/Script/MovieSceneCapture.CompositionGraphCapturePasses";

		// Token: 0x040121C2 RID: 74178
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121C3 RID: 74179
		internal static int __PropertyOffset_Value;

		// Token: 0x040121C4 RID: 74180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Value;
	}
}
