using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000265 RID: 613
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWwiseTreeSelector")]
	[UnrealStructLayout(752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class UAkWwiseTreeSelector : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060023D2 RID: 9170 RVA: 0x00035122 File Offset: 0x00033322
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWwiseTreeSelector._ClassPtr;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00035130 File Offset: 0x00033330
		public UAkWwiseTreeSelector() : this(BuiltinUtils.AllocNativeUObject(UAkWwiseTreeSelector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00035158 File Offset: 0x00033358
		public UAkWwiseTreeSelector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWwiseTreeSelector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0003518C File Offset: 0x0003338C
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x000351C5 File Offset: 0x000333C5
		public FOnItemSelectionChanged OnSelectionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemSelectionChanged result;
				if ((result = this._OnSelectionChanged) == null)
				{
					result = (this._OnSelectionChanged = new FOnItemSelectionChanged(base.NativePtr + (IntPtr)UAkWwiseTreeSelector.__PropertyOffset_OnSelectionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkWwiseTreeSelector.__PropertyOffset_OnSelectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x000351E8 File Offset: 0x000333E8
		// (set) Token: 0x060023D8 RID: 9176 RVA: 0x00035221 File Offset: 0x00033421
		public FOnItemDragDetected OnItemDragged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemDragDetected result;
				if ((result = this._OnItemDragged) == null)
				{
					result = (this._OnItemDragged = new FOnItemDragDetected(base.NativePtr + (IntPtr)UAkWwiseTreeSelector.__PropertyOffset_OnItemDragged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkWwiseTreeSelector.__PropertyOffset_OnItemDragged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00035242 File Offset: 0x00033442
		static UAkWwiseTreeSelector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWwiseTreeSelector");
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00035250 File Offset: 0x00033450
		protected UAkWwiseTreeSelector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C6D RID: 3181
		public new const string __ObjectPath = "/Script/AkAudio.AkWwiseTreeSelector";

		// Token: 0x04000C6E RID: 3182
		private static IntPtr _ClassPtr;

		// Token: 0x04000C6F RID: 3183
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000C70 RID: 3184
		internal static int __PropertyOffset_OnSelectionChanged;

		// Token: 0x04000C71 RID: 3185
		[Nullable(2)]
		private FOnItemSelectionChanged _OnSelectionChanged;

		// Token: 0x04000C72 RID: 3186
		internal static int __PropertyOffset_OnItemDragged;

		// Token: 0x04000C73 RID: 3187
		[Nullable(2)]
		private FOnItemDragDetected _OnItemDragged;
	}
}
