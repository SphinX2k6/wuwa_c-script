using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EA8 RID: 3752
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshRefCheck")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMeshRefCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CB12 RID: 51986 RVA: 0x00127F90 File Offset: 0x00126190
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshRefCheck._ScriptStructPtr != 0) ? FMeshRefCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshRefCheck", ref FMeshRefCheck._ScriptStructPtr);
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x0600CB13 RID: 51987 RVA: 0x00127FB4 File Offset: 0x001261B4
		// (set) Token: 0x0600CB14 RID: 51988 RVA: 0x00127FF7 File Offset: 0x001261F7
		public TArray<string> ValidDirectory
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ValidDirectory) == null)
				{
					result = (this._ValidDirectory = new TArray<string>(base.NativePtr + (IntPtr)FMeshRefCheck.__PropertyOffset_ValidDirectory, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ValidDirectory.CopyAssign(value);
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x0600CB15 RID: 51989 RVA: 0x00128008 File Offset: 0x00126208
		// (set) Token: 0x0600CB16 RID: 51990 RVA: 0x0012804B File Offset: 0x0012624B
		public TArray<string> Temporarydirectory
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Temporarydirectory) == null)
				{
					result = (this._Temporarydirectory = new TArray<string>(base.NativePtr + (IntPtr)FMeshRefCheck.__PropertyOffset_Temporarydirectory, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Temporarydirectory.CopyAssign(value);
			}
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x0600CB17 RID: 51991 RVA: 0x0012805C File Offset: 0x0012625C
		// (set) Token: 0x0600CB18 RID: 51992 RVA: 0x0012809F File Offset: 0x0012629F
		public TArray<string> DonotCheckDirectory
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DonotCheckDirectory) == null)
				{
					result = (this._DonotCheckDirectory = new TArray<string>(base.NativePtr + (IntPtr)FMeshRefCheck.__PropertyOffset_DonotCheckDirectory, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DonotCheckDirectory.CopyAssign(value);
			}
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x001280AD File Offset: 0x001262AD
		public FMeshRefCheck()
		{
		}

		// Token: 0x0600CB1A RID: 51994 RVA: 0x001280B5 File Offset: 0x001262B5
		public FMeshRefCheck(TArray<string> ValidDirectory, TArray<string> Temporarydirectory, TArray<string> DonotCheckDirectory)
		{
			this.ValidDirectory = ValidDirectory;
			this.Temporarydirectory = Temporarydirectory;
			this.DonotCheckDirectory = DonotCheckDirectory;
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x001280D2 File Offset: 0x001262D2
		protected override IntPtr GetUStructPtr()
		{
			return FMeshRefCheck.StaticStruct();
		}

		// Token: 0x0600CB1C RID: 51996 RVA: 0x001280DE File Offset: 0x001262DE
		[NullableContext(2)]
		public FMeshRefCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CB1D RID: 51997 RVA: 0x001280E8 File Offset: 0x001262E8
		public FMeshRefCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x001280F3 File Offset: 0x001262F3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshRefCheck(Pointer, false, true);
		}

		// Token: 0x0600CB1F RID: 51999 RVA: 0x001280FD File Offset: 0x001262FD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshRefCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04006D6D RID: 28013
		public const string __ObjectPath = "/Script/Engine.MeshRefCheck";

		// Token: 0x04006D6E RID: 28014
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006D6F RID: 28015
		internal static int __PropertyOffset_ValidDirectory;

		// Token: 0x04006D70 RID: 28016
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ValidDirectory;

		// Token: 0x04006D71 RID: 28017
		internal static int __PropertyOffset_Temporarydirectory;

		// Token: 0x04006D72 RID: 28018
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Temporarydirectory;

		// Token: 0x04006D73 RID: 28019
		internal static int __PropertyOffset_DonotCheckDirectory;

		// Token: 0x04006D74 RID: 28020
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DonotCheckDirectory;
	}
}
